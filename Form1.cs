using System;
using System.Windows.Forms;

namespace MiniGasStation
{
    public partial class Form1 : Form
    {
        private string savedReceipt = null; // null = no valid computation

        public Form1() { InitializeComponent(); }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            savedReceipt = null; // old results can no longer be used for the receipt
        }

        private void ClearResults()
        {
            txtTankSpace.Text = txtGrossAmount.Text = txtVolDiscount.Text = txtLoyaltyDiscount.Text = "";
            txtNetAmount.Text = txtVatAmount.Text = txtChange.Text = txtPointsEarned.Text = txtTankStatus.Text = "";
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            savedReceipt = null;
            ClearResults();

            if (txtPumpNo.Text.Trim() == "" || txtCustomer.Text.Trim() == "" ||
                txtPlateNo.Text.Trim() == "" || txtFuelType.Text.Trim() == "")
            {
                MessageBox.Show("Please complete all pump and customer information.");
                return;
            }

            if (!decimal.TryParse(txtLiters.Text.Trim(), out decimal liters) ||
                !decimal.TryParse(txtPricePerLiter.Text.Trim(), out decimal price) ||
                !decimal.TryParse(txtCashTendered.Text.Trim(), out decimal cash) ||
                !int.TryParse(txtTankCapacity.Text.Trim(), out int capacity) ||
                !int.TryParse(txtFuelLevel.Text.Trim(), out int level) ||
                !int.TryParse(txtLoyaltyPoints.Text.Trim(), out int points))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            if (liters < 0 || price < 0 || cash < 0 || capacity < 0 || level < 0 || points < 0)
            {
                MessageBox.Show("Negative values are not allowed.");
                return;
            }
            if (liters <= 0 || price <= 0 || capacity <= 0)
            {
                MessageBox.Show("Liters, price per liter, and tank capacity must be greater than zero.");
                return;
            }
            if (level > capacity)
            {
                MessageBox.Show("Current fuel level cannot exceed tank capacity.");
                return;
            }
            int space = capacity - level;
            if (liters > space)
            {
                MessageBox.Show("Fuel requested exceeds available tank space.");
                return;
            }

            decimal gross = liters * price;

            decimal discPerLiter;
            if (liters >= 40) discPerLiter = 1.00m;
            else if (liters >= 20) discPerLiter = 0.50m;
            else discPerLiter = 0.00m;
            decimal volDisc = liters * discPerLiter;

            decimal loyalty = Math.Min((points / 100) * 10m, 0.20m * (gross - volDisc));
            decimal net = gross - volDisc - loyalty;

            if (cash < net)
            {
                MessageBox.Show("Insufficient cash tendered.");
                return;
            }

            decimal vat = net / 1.12m * 0.12m;
            decimal change = cash - net;
            int earned = (int)(net / 50);

            decimal newLevel = level + liters;
            string status;
            if (newLevel == capacity) status = "FULL TANK";
            else if (newLevel >= 0.80m * capacity) status = "ALMOST FULL";
            else if (newLevel >= 0.50m * capacity) status = "HALF TANK";
            else status = "LOW LEVEL";

            txtTankSpace.Text = space.ToString();
            txtGrossAmount.Text = gross.ToString("F2");
            txtVolDiscount.Text = volDisc.ToString("F2");
            txtLoyaltyDiscount.Text = loyalty.ToString("F2");
            txtNetAmount.Text = net.ToString("F2");
            txtVatAmount.Text = vat.ToString("F2");
            txtChange.Text = change.ToString("F2");
            txtPointsEarned.Text = earned.ToString();
            txtTankStatus.Text = status;

            savedReceipt =
                "====== FUEL RECEIPT ======\n" +
                $"Pump No: {txtPumpNo.Text.Trim()}   Customer: {txtCustomer.Text.Trim()}   Plate: {txtPlateNo.Text.Trim()}\n" +
                $"Fuel Type: {txtFuelType.Text.Trim()}   Liters: {liters:F2}   Price: {price:F2}\n" +
                $"Tank: {level} L of {capacity} L   Loyalty Points: {points}\n" +
                $"Available Tank Space: {space}\n" +
                $"Gross Amount: {gross:F2}\n" +
                $"Volume Discount: {volDisc:F2}   Loyalty Discount: {loyalty:F2}\n" +
                $"Net Amount Due: {net:F2}\n" +
                $"VAT Included: {vat:F2}\n" +
                $"Cash Tendered: {cash:F2}   Change: {change:F2}\n" +
                $"Points Earned: {earned}   Tank Status: {status}";

            MessageBox.Show("Fuel bill computed successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox) c.Text = "";
            savedReceipt = null;
            txtPumpNo.Focus();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (savedReceipt == null)
            {
                MessageBox.Show("Please compute the bill first.");
                return;
            }
            MessageBox.Show(savedReceipt, "Receipt");
        }

        private void btnExit_Click(object sender, EventArgs e) { Close(); }
    }
}
