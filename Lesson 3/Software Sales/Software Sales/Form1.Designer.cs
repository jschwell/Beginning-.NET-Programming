namespace Software_Sales
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
            this.lblPackagesCaption = new System.Windows.Forms.Label();
            this.txtPackages = new System.Windows.Forms.TextBox();
            this.lblDiscountCaption = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPackagesCaption
            // 
            this.lblPackagesCaption.AutoSize = true;
            this.lblPackagesCaption.Location = new System.Drawing.Point(12, 15);
            this.lblPackagesCaption.Name = "lblPackagesCaption";
            this.lblPackagesCaption.Size = new System.Drawing.Size(135, 13);
            this.lblPackagesCaption.TabIndex = 0;
            this.lblPackagesCaption.Text = "Enter number of packages:";
            // 
            // txtPackages
            // 
            this.txtPackages.Location = new System.Drawing.Point(153, 12);
            this.txtPackages.Name = "txtPackages";
            this.txtPackages.Size = new System.Drawing.Size(100, 20);
            this.txtPackages.TabIndex = 1;
            // 
            // lblDiscountCaption
            // 
            this.lblDiscountCaption.AutoSize = true;
            this.lblDiscountCaption.Location = new System.Drawing.Point(95, 45);
            this.lblDiscountCaption.Name = "lblDiscountCaption";
            this.lblDiscountCaption.Size = new System.Drawing.Size(52, 13);
            this.lblDiscountCaption.TabIndex = 2;
            this.lblDiscountCaption.Text = "Discount:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(153, 40);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(100, 23);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(113, 78);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCaption.TabIndex = 4;
            this.lblTotalCaption.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(153, 73);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 117);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(105, 117);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(186, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
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
            this.ClientSize = new System.Drawing.Size(284, 164);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalCaption);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblDiscountCaption);
            this.Controls.Add(this.txtPackages);
            this.Controls.Add(this.lblPackagesCaption);
            this.Name = "Form1";
            this.Text = "Software Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackagesCaption;
        private System.Windows.Forms.TextBox txtPackages;
        private System.Windows.Forms.Label lblDiscountCaption;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

