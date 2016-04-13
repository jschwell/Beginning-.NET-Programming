namespace Total_Sales
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
            this.lbSales = new System.Windows.Forms.ListBox();
            this.lblTotalSalesCaption = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSalesCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSales
            // 
            this.lbSales.FormattingEnabled = true;
            this.lbSales.Location = new System.Drawing.Point(12, 25);
            this.lbSales.Name = "lbSales";
            this.lbSales.Size = new System.Drawing.Size(120, 108);
            this.lbSales.TabIndex = 3;
            // 
            // lblTotalSalesCaption
            // 
            this.lblTotalSalesCaption.AutoSize = true;
            this.lblTotalSalesCaption.Location = new System.Drawing.Point(143, 57);
            this.lblTotalSalesCaption.Name = "lblTotalSalesCaption";
            this.lblTotalSalesCaption.Size = new System.Drawing.Size(63, 13);
            this.lblTotalSalesCaption.TabIndex = 1;
            this.lblTotalSalesCaption.Text = "Total Sales:";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSales.Location = new System.Drawing.Point(146, 72);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(100, 23);
            this.lblTotalSales.TabIndex = 2;
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 148);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Get Sales";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 148);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(174, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSalesCaption
            // 
            this.lblSalesCaption.AutoSize = true;
            this.lblSalesCaption.Location = new System.Drawing.Point(12, 9);
            this.lblSalesCaption.Name = "lblSalesCaption";
            this.lblSalesCaption.Size = new System.Drawing.Size(36, 13);
            this.lblSalesCaption.TabIndex = 6;
            this.lblSalesCaption.Text = "Sales:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(261, 186);
            this.Controls.Add(this.lblSalesCaption);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.lblTotalSalesCaption);
            this.Controls.Add(this.lbSales);
            this.Name = "Form1";
            this.Text = "Total Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSales;
        private System.Windows.Forms.Label lblTotalSalesCaption;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSalesCaption;
    }
}

