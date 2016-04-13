namespace Hospital_Charges
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
            this.lblDaysSpent = new System.Windows.Forms.Label();
            this.lblMedCharges = new System.Windows.Forms.Label();
            this.lblSurgicalCharges = new System.Windows.Forms.Label();
            this.lblLabFees = new System.Windows.Forms.Label();
            this.lblRehabCharges = new System.Windows.Forms.Label();
            this.txtDaysSpent = new System.Windows.Forms.TextBox();
            this.txtMedCharges = new System.Windows.Forms.TextBox();
            this.txtSurgicalCharges = new System.Windows.Forms.TextBox();
            this.txtLabFees = new System.Windows.Forms.TextBox();
            this.txtRehabCharges = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDaysSpent
            // 
            this.lblDaysSpent.AutoSize = true;
            this.lblDaysSpent.Location = new System.Drawing.Point(101, 15);
            this.lblDaysSpent.Name = "lblDaysSpent";
            this.lblDaysSpent.Size = new System.Drawing.Size(65, 13);
            this.lblDaysSpent.TabIndex = 0;
            this.lblDaysSpent.Text = "Days Spent:";
            // 
            // lblMedCharges
            // 
            this.lblMedCharges.AutoSize = true;
            this.lblMedCharges.Location = new System.Drawing.Point(62, 41);
            this.lblMedCharges.Name = "lblMedCharges";
            this.lblMedCharges.Size = new System.Drawing.Size(104, 13);
            this.lblMedCharges.TabIndex = 1;
            this.lblMedCharges.Text = "Medication Charges:";
            // 
            // lblSurgicalCharges
            // 
            this.lblSurgicalCharges.AutoSize = true;
            this.lblSurgicalCharges.Location = new System.Drawing.Point(76, 67);
            this.lblSurgicalCharges.Name = "lblSurgicalCharges";
            this.lblSurgicalCharges.Size = new System.Drawing.Size(90, 13);
            this.lblSurgicalCharges.TabIndex = 2;
            this.lblSurgicalCharges.Text = "Surgical Charges:";
            // 
            // lblLabFees
            // 
            this.lblLabFees.AutoSize = true;
            this.lblLabFees.Location = new System.Drawing.Point(112, 93);
            this.lblLabFees.Name = "lblLabFees";
            this.lblLabFees.Size = new System.Drawing.Size(54, 13);
            this.lblLabFees.TabIndex = 3;
            this.lblLabFees.Text = "Lab Fees:";
            // 
            // lblRehabCharges
            // 
            this.lblRehabCharges.AutoSize = true;
            this.lblRehabCharges.Location = new System.Drawing.Point(8, 119);
            this.lblRehabCharges.Name = "lblRehabCharges";
            this.lblRehabCharges.Size = new System.Drawing.Size(158, 13);
            this.lblRehabCharges.TabIndex = 4;
            this.lblRehabCharges.Text = "Physical Rehabilitation Charges:";
            // 
            // txtDaysSpent
            // 
            this.txtDaysSpent.Location = new System.Drawing.Point(172, 12);
            this.txtDaysSpent.Name = "txtDaysSpent";
            this.txtDaysSpent.Size = new System.Drawing.Size(100, 20);
            this.txtDaysSpent.TabIndex = 0;
            // 
            // txtMedCharges
            // 
            this.txtMedCharges.Location = new System.Drawing.Point(172, 38);
            this.txtMedCharges.Name = "txtMedCharges";
            this.txtMedCharges.Size = new System.Drawing.Size(100, 20);
            this.txtMedCharges.TabIndex = 1;
            // 
            // txtSurgicalCharges
            // 
            this.txtSurgicalCharges.Location = new System.Drawing.Point(172, 64);
            this.txtSurgicalCharges.Name = "txtSurgicalCharges";
            this.txtSurgicalCharges.Size = new System.Drawing.Size(100, 20);
            this.txtSurgicalCharges.TabIndex = 2;
            // 
            // txtLabFees
            // 
            this.txtLabFees.Location = new System.Drawing.Point(172, 90);
            this.txtLabFees.Name = "txtLabFees";
            this.txtLabFees.Size = new System.Drawing.Size(100, 20);
            this.txtLabFees.TabIndex = 3;
            // 
            // txtRehabCharges
            // 
            this.txtRehabCharges.Location = new System.Drawing.Point(172, 116);
            this.txtRehabCharges.Name = "txtRehabCharges";
            this.txtRehabCharges.Size = new System.Drawing.Size(100, 20);
            this.txtRehabCharges.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(23, 203);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(104, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(185, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(108, 165);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(58, 13);
            this.lblTotalCaption.TabIndex = 13;
            this.lblTotalCaption.Text = "Total Cost:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(172, 160);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalCaption);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtRehabCharges);
            this.Controls.Add(this.txtLabFees);
            this.Controls.Add(this.txtSurgicalCharges);
            this.Controls.Add(this.txtMedCharges);
            this.Controls.Add(this.txtDaysSpent);
            this.Controls.Add(this.lblRehabCharges);
            this.Controls.Add(this.lblLabFees);
            this.Controls.Add(this.lblSurgicalCharges);
            this.Controls.Add(this.lblMedCharges);
            this.Controls.Add(this.lblDaysSpent);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaysSpent;
        private System.Windows.Forms.Label lblMedCharges;
        private System.Windows.Forms.Label lblSurgicalCharges;
        private System.Windows.Forms.Label lblLabFees;
        private System.Windows.Forms.Label lblRehabCharges;
        private System.Windows.Forms.TextBox txtDaysSpent;
        private System.Windows.Forms.TextBox txtMedCharges;
        private System.Windows.Forms.TextBox txtSurgicalCharges;
        private System.Windows.Forms.TextBox txtLabFees;
        private System.Windows.Forms.TextBox txtRehabCharges;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
    }
}

