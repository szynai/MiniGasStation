namespace MiniGasStation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPumpNo = new System.Windows.Forms.Label();
            this.txtPumpNo = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblPlateNo = new System.Windows.Forms.Label();
            this.txtPlateNo = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.lblLiters = new System.Windows.Forms.Label();
            this.txtLiters = new System.Windows.Forms.TextBox();
            this.lblPricePerLiter = new System.Windows.Forms.Label();
            this.txtPricePerLiter = new System.Windows.Forms.TextBox();
            this.lblTankCapacity = new System.Windows.Forms.Label();
            this.txtTankCapacity = new System.Windows.Forms.TextBox();
            this.lblFuelLevel = new System.Windows.Forms.Label();
            this.txtFuelLevel = new System.Windows.Forms.TextBox();
            this.lblLoyaltyPoints = new System.Windows.Forms.Label();
            this.txtLoyaltyPoints = new System.Windows.Forms.TextBox();
            this.lblCashTendered = new System.Windows.Forms.Label();
            this.txtCashTendered = new System.Windows.Forms.TextBox();
            this.lblTankSpace = new System.Windows.Forms.Label();
            this.txtTankSpace = new System.Windows.Forms.TextBox();
            this.lblGrossAmount = new System.Windows.Forms.Label();
            this.txtGrossAmount = new System.Windows.Forms.TextBox();
            this.lblVolDiscount = new System.Windows.Forms.Label();
            this.txtVolDiscount = new System.Windows.Forms.TextBox();
            this.lblLoyaltyDiscount = new System.Windows.Forms.Label();
            this.txtLoyaltyDiscount = new System.Windows.Forms.TextBox();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.lblVatAmount = new System.Windows.Forms.Label();
            this.txtVatAmount = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblPointsEarned = new System.Windows.Forms.Label();
            this.txtPointsEarned = new System.Windows.Forms.TextBox();
            this.lblTankStatus = new System.Windows.Forms.Label();
            this.txtTankStatus = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Text = "Gas Station Billing System";

            // lblPumpNo
            this.lblPumpNo.AutoSize = true;
            this.lblPumpNo.Location = new System.Drawing.Point(20, 59);
            this.lblPumpNo.Text = "Pump Number";

            // txtPumpNo
            this.txtPumpNo.Location = new System.Drawing.Point(195, 55);
            this.txtPumpNo.Size = new System.Drawing.Size(150, 23);
            this.txtPumpNo.TextChanged += new System.EventHandler(this.Input_TextChanged);

            // lblCustomer
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(20, 91);
            this.lblCustomer.Text = "Customer Name";

            // txtCustomer
            this.txtCustomer.Location = new System.Drawing.Point(195, 87);
            this.txtCustomer.Size = new System.Drawing.Size(150, 23);
            this.txtCustomer.TextChanged += new System.EventHandler(this.Input_TextChanged);

            // lblPlateNo
            this.lblPlateNo.AutoSize = true;
            this.lblPlateNo.Location = new System.Drawing.Point(20, 123);
            this.lblPlateNo.Text = "Plate Number";

            // txtPlateNo
            this.txtPlateNo.Location = new System.Drawing.Point(195, 119);
            this.txtPlateNo.Size = new System.Drawing.Size(150, 23);
            this.txtPlateNo.TextChanged += new System.EventHandler(this.Input_TextChanged);

            // lblFuelType
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(20, 155);
            this.lblFuelType.Text = "Fuel Type";

            // txtFuelType
            this.txtFuelType.Location = new System.Drawing.Point(195, 151);
            this.txtFuelType.Size = new System.Drawing.Size(150, 23);
            this.txtFuelType.TextChanged += new System.EventHandler(this.Input_TextChanged);

            // lblLiters
            this.lblLiters.AutoSize = true;
            this.lblLiters.Location = new System.Drawing.Point(20, 187);
            this.lblLiters.Text = "Liters Requested";

            // txtLiters
            this.txtLiters.Location = new System.Drawing.Point(195, 183);
            this.txtLiters.Size = new System.Drawing.Size(150, 23);
            this.txtLiters.TextChanged += new System.EventHandler(this.Input_TextChanged);

            // lblPricePerLiter
            this.lblPricePerLiter.AutoSize = true;
            this.lblPricePerLiter.Location = new System.Drawing.Point(20, 219);
            this.lblPricePerLiter.Text = "Price per Liter";

            // txtPricePerLiter
            this.txtPricePerLiter.Location = new System.Drawing.Point(195, 215);
            this.txtPricePerLiter.Size = new System.Drawing.Size(150, 23);
            this.txtPricePerLiter.TextChanged += new System.EventHandler(this.Input_TextChanged);

            // lblTankCapacity
            this.lblTankCapacity.AutoSize = true;
            this.lblTankCapacity.Location = new System.Drawing.Point(20, 251);
            this.lblTankCapacity.Text = "Tank Capacity (L)";

            // txtTankCapacity
            this.txtTankCapacity.Location = new System.Drawing.Point(195, 247);
            this.txtTankCapacity.Size = new System.Drawing.Size(150, 23);
            this.txtTankCapacity.TextChanged += new System.EventHandler(this.Input_TextChanged);

            // lblFuelLevel
            this.lblFuelLevel.AutoSize = true;
            this.lblFuelLevel.Location = new System.Drawing.Point(20, 283);
            this.lblFuelLevel.Text = "Current Fuel Level (L)";

            // txtFuelLevel
            this.txtFuelLevel.Location = new System.Drawing.Point(195, 279);
            this.txtFuelLevel.Size = new System.Drawing.Size(150, 23);
            this.txtFuelLevel.TextChanged += new System.EventHandler(this.Input_TextChanged);

            // lblLoyaltyPoints
            this.lblLoyaltyPoints.AutoSize = true;
            this.lblLoyaltyPoints.Location = new System.Drawing.Point(20, 315);
            this.lblLoyaltyPoints.Text = "Loyalty Points";

            // txtLoyaltyPoints
            this.txtLoyaltyPoints.Location = new System.Drawing.Point(195, 311);
            this.txtLoyaltyPoints.Size = new System.Drawing.Size(150, 23);
            this.txtLoyaltyPoints.TextChanged += new System.EventHandler(this.Input_TextChanged);

            // lblCashTendered
            this.lblCashTendered.AutoSize = true;
            this.lblCashTendered.Location = new System.Drawing.Point(20, 347);
            this.lblCashTendered.Text = "Cash Tendered";

            // txtCashTendered
            this.txtCashTendered.Location = new System.Drawing.Point(195, 343);
            this.txtCashTendered.Size = new System.Drawing.Size(150, 23);
            this.txtCashTendered.TextChanged += new System.EventHandler(this.Input_TextChanged);

            // lblTankSpace
            this.lblTankSpace.AutoSize = true;
            this.lblTankSpace.Location = new System.Drawing.Point(390, 59);
            this.lblTankSpace.Text = "Available Tank Space";

            // txtTankSpace
            this.txtTankSpace.Location = new System.Drawing.Point(565, 55);
            this.txtTankSpace.Size = new System.Drawing.Size(150, 23);
            this.txtTankSpace.ReadOnly = true;

            // lblGrossAmount
            this.lblGrossAmount.AutoSize = true;
            this.lblGrossAmount.Location = new System.Drawing.Point(390, 91);
            this.lblGrossAmount.Text = "Gross Amount";

            // txtGrossAmount
            this.txtGrossAmount.Location = new System.Drawing.Point(565, 87);
            this.txtGrossAmount.Size = new System.Drawing.Size(150, 23);
            this.txtGrossAmount.ReadOnly = true;

            // lblVolDiscount
            this.lblVolDiscount.AutoSize = true;
            this.lblVolDiscount.Location = new System.Drawing.Point(390, 123);
            this.lblVolDiscount.Text = "Volume Discount";

            // txtVolDiscount
            this.txtVolDiscount.Location = new System.Drawing.Point(565, 119);
            this.txtVolDiscount.Size = new System.Drawing.Size(150, 23);
            this.txtVolDiscount.ReadOnly = true;

            // lblLoyaltyDiscount
            this.lblLoyaltyDiscount.AutoSize = true;
            this.lblLoyaltyDiscount.Location = new System.Drawing.Point(390, 155);
            this.lblLoyaltyDiscount.Text = "Loyalty Discount";

            // txtLoyaltyDiscount
            this.txtLoyaltyDiscount.Location = new System.Drawing.Point(565, 151);
            this.txtLoyaltyDiscount.Size = new System.Drawing.Size(150, 23);
            this.txtLoyaltyDiscount.ReadOnly = true;

            // lblNetAmount
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Location = new System.Drawing.Point(390, 187);
            this.lblNetAmount.Text = "Net Amount Due";

            // txtNetAmount
            this.txtNetAmount.Location = new System.Drawing.Point(565, 183);
            this.txtNetAmount.Size = new System.Drawing.Size(150, 23);
            this.txtNetAmount.ReadOnly = true;

            // lblVatAmount
            this.lblVatAmount.AutoSize = true;
            this.lblVatAmount.Location = new System.Drawing.Point(390, 219);
            this.lblVatAmount.Text = "VAT Included";

            // txtVatAmount
            this.txtVatAmount.Location = new System.Drawing.Point(565, 215);
            this.txtVatAmount.Size = new System.Drawing.Size(150, 23);
            this.txtVatAmount.ReadOnly = true;

            // lblChange
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(390, 251);
            this.lblChange.Text = "Change";

            // txtChange
            this.txtChange.Location = new System.Drawing.Point(565, 247);
            this.txtChange.Size = new System.Drawing.Size(150, 23);
            this.txtChange.ReadOnly = true;

            // lblPointsEarned
            this.lblPointsEarned.AutoSize = true;
            this.lblPointsEarned.Location = new System.Drawing.Point(390, 283);
            this.lblPointsEarned.Text = "Points Earned";

            // txtPointsEarned
            this.txtPointsEarned.Location = new System.Drawing.Point(565, 279);
            this.txtPointsEarned.Size = new System.Drawing.Size(150, 23);
            this.txtPointsEarned.ReadOnly = true;

            // lblTankStatus
            this.lblTankStatus.AutoSize = true;
            this.lblTankStatus.Location = new System.Drawing.Point(390, 315);
            this.lblTankStatus.Text = "Tank Status After Refuel";

            // txtTankStatus
            this.txtTankStatus.Location = new System.Drawing.Point(565, 311);
            this.txtTankStatus.Size = new System.Drawing.Size(150, 23);
            this.txtTankStatus.ReadOnly = true;

            // btnCompute
            this.btnCompute.Location = new System.Drawing.Point(20, 395);
            this.btnCompute.Size = new System.Drawing.Size(125, 35);
            this.btnCompute.Text = "Compute Bill";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(160, 395);
            this.btnClear.Size = new System.Drawing.Size(125, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnReport
            this.btnReport.Location = new System.Drawing.Point(300, 395);
            this.btnReport.Size = new System.Drawing.Size(125, 35);
            this.btnReport.Text = "View Receipt";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(440, 395);
            this.btnExit.Size = new System.Drawing.Size(125, 35);
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPumpNo);
            this.Controls.Add(this.txtPumpNo);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblPlateNo);
            this.Controls.Add(this.txtPlateNo);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.lblLiters);
            this.Controls.Add(this.txtLiters);
            this.Controls.Add(this.lblPricePerLiter);
            this.Controls.Add(this.txtPricePerLiter);
            this.Controls.Add(this.lblTankCapacity);
            this.Controls.Add(this.txtTankCapacity);
            this.Controls.Add(this.lblFuelLevel);
            this.Controls.Add(this.txtFuelLevel);
            this.Controls.Add(this.lblLoyaltyPoints);
            this.Controls.Add(this.txtLoyaltyPoints);
            this.Controls.Add(this.lblCashTendered);
            this.Controls.Add(this.txtCashTendered);
            this.Controls.Add(this.lblTankSpace);
            this.Controls.Add(this.txtTankSpace);
            this.Controls.Add(this.lblGrossAmount);
            this.Controls.Add(this.txtGrossAmount);
            this.Controls.Add(this.lblVolDiscount);
            this.Controls.Add(this.txtVolDiscount);
            this.Controls.Add(this.lblLoyaltyDiscount);
            this.Controls.Add(this.txtLoyaltyDiscount);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.txtNetAmount);
            this.Controls.Add(this.lblVatAmount);
            this.Controls.Add(this.txtVatAmount);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblPointsEarned);
            this.Controls.Add(this.txtPointsEarned);
            this.Controls.Add(this.lblTankStatus);
            this.Controls.Add(this.txtTankStatus);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniGasStation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPumpNo;
        private System.Windows.Forms.TextBox txtPumpNo;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblPlateNo;
        private System.Windows.Forms.TextBox txtPlateNo;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.Label lblLiters;
        private System.Windows.Forms.TextBox txtLiters;
        private System.Windows.Forms.Label lblPricePerLiter;
        private System.Windows.Forms.TextBox txtPricePerLiter;
        private System.Windows.Forms.Label lblTankCapacity;
        private System.Windows.Forms.TextBox txtTankCapacity;
        private System.Windows.Forms.Label lblFuelLevel;
        private System.Windows.Forms.TextBox txtFuelLevel;
        private System.Windows.Forms.Label lblLoyaltyPoints;
        private System.Windows.Forms.TextBox txtLoyaltyPoints;
        private System.Windows.Forms.Label lblCashTendered;
        private System.Windows.Forms.TextBox txtCashTendered;
        private System.Windows.Forms.Label lblTankSpace;
        private System.Windows.Forms.TextBox txtTankSpace;
        private System.Windows.Forms.Label lblGrossAmount;
        private System.Windows.Forms.TextBox txtGrossAmount;
        private System.Windows.Forms.Label lblVolDiscount;
        private System.Windows.Forms.TextBox txtVolDiscount;
        private System.Windows.Forms.Label lblLoyaltyDiscount;
        private System.Windows.Forms.TextBox txtLoyaltyDiscount;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label lblVatAmount;
        private System.Windows.Forms.TextBox txtVatAmount;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblPointsEarned;
        private System.Windows.Forms.TextBox txtPointsEarned;
        private System.Windows.Forms.Label lblTankStatus;
        private System.Windows.Forms.TextBox txtTankStatus;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
    }
}
