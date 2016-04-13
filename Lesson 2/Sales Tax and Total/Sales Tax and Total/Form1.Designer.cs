namespace Sales_Tax_and_Total
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPurchasePriceCaption = new System.Windows.Forms.Label();
            this.lblStateTaxCaption = new System.Windows.Forms.Label();
            this.lblCountyTaxCaption = new System.Windows.Forms.Label();
            this.lblTotalTaxCaption = new System.Windows.Forms.Label();
            this.lblTotalPriceCaption = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblStateTax = new System.Windows.Forms.Label();
            this.lblCountyTax = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPurchasePriceCaption
            // 
            this.lblPurchasePriceCaption.AutoSize = true;
            this.lblPurchasePriceCaption.Location = new System.Drawing.Point(11, 15);
            this.lblPurchasePriceCaption.Name = "lblPurchasePriceCaption";
            this.lblPurchasePriceCaption.Size = new System.Drawing.Size(108, 13);
            this.lblPurchasePriceCaption.TabIndex = 0;
            this.lblPurchasePriceCaption.Text = "Enter purchase price:";
            // 
            // lblStateTaxCaption
            // 
            this.lblStateTaxCaption.AutoSize = true;
            this.lblStateTaxCaption.Location = new System.Drawing.Point(40, 48);
            this.lblStateTaxCaption.Name = "lblStateTaxCaption";
            this.lblStateTaxCaption.Size = new System.Drawing.Size(79, 13);
            this.lblStateTaxCaption.TabIndex = 1;
            this.lblStateTaxCaption.Text = "State sales tax:";
            // 
            // lblCountyTaxCaption
            // 
            this.lblCountyTaxCaption.AutoSize = true;
            this.lblCountyTaxCaption.Location = new System.Drawing.Point(32, 76);
            this.lblCountyTaxCaption.Name = "lblCountyTaxCaption";
            this.lblCountyTaxCaption.Size = new System.Drawing.Size(87, 13);
            this.lblCountyTaxCaption.TabIndex = 2;
            this.lblCountyTaxCaption.Text = "County sales tax:";
            // 
            // lblTotalTaxCaption
            // 
            this.lblTotalTaxCaption.AutoSize = true;
            this.lblTotalTaxCaption.Location = new System.Drawing.Point(41, 104);
            this.lblTotalTaxCaption.Name = "lblTotalTaxCaption";
            this.lblTotalTaxCaption.Size = new System.Drawing.Size(78, 13);
            this.lblTotalTaxCaption.TabIndex = 3;
            this.lblTotalTaxCaption.Text = "Total sales tax:";
            // 
            // lblTotalPriceCaption
            // 
            this.lblTotalPriceCaption.AutoSize = true;
            this.lblTotalPriceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceCaption.Location = new System.Drawing.Point(47, 132);
            this.lblTotalPriceCaption.Name = "lblTotalPriceCaption";
            this.lblTotalPriceCaption.Size = new System.Drawing.Size(72, 13);
            this.lblTotalPriceCaption.TabIndex = 4;
            this.lblTotalPriceCaption.Text = "Total price:";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(125, 12);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(120, 20);
            this.txtPurchasePrice.TabIndex = 0;
            this.txtPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStateTax
            // 
            this.lblStateTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStateTax.Location = new System.Drawing.Point(125, 43);
            this.lblStateTax.Name = "lblStateTax";
            this.lblStateTax.Size = new System.Drawing.Size(120, 23);
            this.lblStateTax.TabIndex = 1;
            this.lblStateTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountyTax
            // 
            this.lblCountyTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountyTax.Location = new System.Drawing.Point(125, 71);
            this.lblCountyTax.Name = "lblCountyTax";
            this.lblCountyTax.Size = new System.Drawing.Size(120, 23);
            this.lblCountyTax.TabIndex = 2;
            this.lblCountyTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalTax.Location = new System.Drawing.Point(125, 99);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(120, 23);
            this.lblTotalTax.TabIndex = 3;
            this.lblTotalTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPrice.Location = new System.Drawing.Point(125, 127);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(120, 23);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(23, 163);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 24);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(104, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(185, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 24);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalTax);
            this.Controls.Add(this.lblCountyTax);
            this.Controls.Add(this.lblStateTax);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.lblTotalPriceCaption);
            this.Controls.Add(this.lblTotalTaxCaption);
            this.Controls.Add(this.lblCountyTaxCaption);
            this.Controls.Add(this.lblStateTaxCaption);
            this.Controls.Add(this.lblPurchasePriceCaption);
            this.Name = "Form1";
            this.Text = "Sales Tax and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchasePriceCaption;
        private System.Windows.Forms.Label lblStateTaxCaption;
        private System.Windows.Forms.Label lblCountyTaxCaption;
        private System.Windows.Forms.Label lblTotalTaxCaption;
        private System.Windows.Forms.Label lblTotalPriceCaption;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblStateTax;
        private System.Windows.Forms.Label lblCountyTax;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

