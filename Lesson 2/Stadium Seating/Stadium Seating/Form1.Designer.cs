namespace Stadium_Seating
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
            this.grpTicketsSold = new System.Windows.Forms.GroupBox();
            this.txtClassC = new System.Windows.Forms.TextBox();
            this.txtClassA = new System.Windows.Forms.TextBox();
            this.txtClassB = new System.Windows.Forms.TextBox();
            this.lblClassCTicketsCaption = new System.Windows.Forms.Label();
            this.lblClassBTicketsCaption = new System.Windows.Forms.Label();
            this.lblClassATicketsCaption = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.grpRevenue = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblClassCRevenue = new System.Windows.Forms.Label();
            this.lblClassBRevenue = new System.Windows.Forms.Label();
            this.lblClassARevenue = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblClassCRevenueCaption = new System.Windows.Forms.Label();
            this.lblClassBRevenueCaption = new System.Windows.Forms.Label();
            this.lblClassARevenueCaption = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpTicketsSold.SuspendLayout();
            this.grpRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTicketsSold
            // 
            this.grpTicketsSold.Controls.Add(this.txtClassC);
            this.grpTicketsSold.Controls.Add(this.txtClassA);
            this.grpTicketsSold.Controls.Add(this.txtClassB);
            this.grpTicketsSold.Controls.Add(this.lblClassCTicketsCaption);
            this.grpTicketsSold.Controls.Add(this.lblClassBTicketsCaption);
            this.grpTicketsSold.Controls.Add(this.lblClassATicketsCaption);
            this.grpTicketsSold.Controls.Add(this.lblDescription);
            this.grpTicketsSold.Location = new System.Drawing.Point(12, 12);
            this.grpTicketsSold.Name = "grpTicketsSold";
            this.grpTicketsSold.Size = new System.Drawing.Size(271, 168);
            this.grpTicketsSold.TabIndex = 0;
            this.grpTicketsSold.TabStop = false;
            this.grpTicketsSold.Text = "Tickets Sold";
            // 
            // txtClassC
            // 
            this.txtClassC.Location = new System.Drawing.Point(110, 121);
            this.txtClassC.Name = "txtClassC";
            this.txtClassC.Size = new System.Drawing.Size(100, 20);
            this.txtClassC.TabIndex = 2;
            // 
            // txtClassA
            // 
            this.txtClassA.Location = new System.Drawing.Point(110, 69);
            this.txtClassA.Name = "txtClassA";
            this.txtClassA.Size = new System.Drawing.Size(100, 20);
            this.txtClassA.TabIndex = 0;
            // 
            // txtClassB
            // 
            this.txtClassB.Location = new System.Drawing.Point(110, 95);
            this.txtClassB.Name = "txtClassB";
            this.txtClassB.Size = new System.Drawing.Size(100, 20);
            this.txtClassB.TabIndex = 1;
            // 
            // lblClassCTicketsCaption
            // 
            this.lblClassCTicketsCaption.AutoSize = true;
            this.lblClassCTicketsCaption.Location = new System.Drawing.Point(59, 124);
            this.lblClassCTicketsCaption.Name = "lblClassCTicketsCaption";
            this.lblClassCTicketsCaption.Size = new System.Drawing.Size(45, 13);
            this.lblClassCTicketsCaption.TabIndex = 5;
            this.lblClassCTicketsCaption.Text = "Class C:";
            // 
            // lblClassBTicketsCaption
            // 
            this.lblClassBTicketsCaption.AutoSize = true;
            this.lblClassBTicketsCaption.Location = new System.Drawing.Point(59, 98);
            this.lblClassBTicketsCaption.Name = "lblClassBTicketsCaption";
            this.lblClassBTicketsCaption.Size = new System.Drawing.Size(45, 13);
            this.lblClassBTicketsCaption.TabIndex = 4;
            this.lblClassBTicketsCaption.Text = "Class B:";
            // 
            // lblClassATicketsCaption
            // 
            this.lblClassATicketsCaption.AutoSize = true;
            this.lblClassATicketsCaption.Location = new System.Drawing.Point(59, 72);
            this.lblClassATicketsCaption.Name = "lblClassATicketsCaption";
            this.lblClassATicketsCaption.Size = new System.Drawing.Size(45, 13);
            this.lblClassATicketsCaption.TabIndex = 3;
            this.lblClassATicketsCaption.Text = "Class A:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(21, 28);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(227, 31);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // grpRevenue
            // 
            this.grpRevenue.Controls.Add(this.lblTotal);
            this.grpRevenue.Controls.Add(this.lblClassCRevenue);
            this.grpRevenue.Controls.Add(this.lblClassBRevenue);
            this.grpRevenue.Controls.Add(this.lblClassARevenue);
            this.grpRevenue.Controls.Add(this.lblTotalCaption);
            this.grpRevenue.Controls.Add(this.lblClassCRevenueCaption);
            this.grpRevenue.Controls.Add(this.lblClassBRevenueCaption);
            this.grpRevenue.Controls.Add(this.lblClassARevenueCaption);
            this.grpRevenue.Location = new System.Drawing.Point(313, 12);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.Size = new System.Drawing.Size(230, 168);
            this.grpRevenue.TabIndex = 0;
            this.grpRevenue.TabStop = false;
            this.grpRevenue.Text = "Revenue Generated";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(93, 118);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClassCRevenue
            // 
            this.lblClassCRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassCRevenue.Location = new System.Drawing.Point(93, 92);
            this.lblClassCRevenue.Name = "lblClassCRevenue";
            this.lblClassCRevenue.Size = new System.Drawing.Size(100, 23);
            this.lblClassCRevenue.TabIndex = 6;
            this.lblClassCRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClassBRevenue
            // 
            this.lblClassBRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassBRevenue.Location = new System.Drawing.Point(93, 66);
            this.lblClassBRevenue.Name = "lblClassBRevenue";
            this.lblClassBRevenue.Size = new System.Drawing.Size(100, 23);
            this.lblClassBRevenue.TabIndex = 5;
            this.lblClassBRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClassARevenue
            // 
            this.lblClassARevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassARevenue.Location = new System.Drawing.Point(93, 40);
            this.lblClassARevenue.Name = "lblClassARevenue";
            this.lblClassARevenue.Size = new System.Drawing.Size(100, 23);
            this.lblClassARevenue.TabIndex = 4;
            this.lblClassARevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(53, 123);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCaption.TabIndex = 3;
            this.lblTotalCaption.Text = "Total:";
            // 
            // lblClassCRevenueCaption
            // 
            this.lblClassCRevenueCaption.AutoSize = true;
            this.lblClassCRevenueCaption.Location = new System.Drawing.Point(42, 97);
            this.lblClassCRevenueCaption.Name = "lblClassCRevenueCaption";
            this.lblClassCRevenueCaption.Size = new System.Drawing.Size(45, 13);
            this.lblClassCRevenueCaption.TabIndex = 2;
            this.lblClassCRevenueCaption.Text = "Class C:";
            // 
            // lblClassBRevenueCaption
            // 
            this.lblClassBRevenueCaption.AutoSize = true;
            this.lblClassBRevenueCaption.Location = new System.Drawing.Point(42, 71);
            this.lblClassBRevenueCaption.Name = "lblClassBRevenueCaption";
            this.lblClassBRevenueCaption.Size = new System.Drawing.Size(45, 13);
            this.lblClassBRevenueCaption.TabIndex = 1;
            this.lblClassBRevenueCaption.Text = "Class B:";
            // 
            // lblClassARevenueCaption
            // 
            this.lblClassARevenueCaption.AutoSize = true;
            this.lblClassARevenueCaption.Location = new System.Drawing.Point(42, 45);
            this.lblClassARevenueCaption.Name = "lblClassARevenueCaption";
            this.lblClassARevenueCaption.Size = new System.Drawing.Size(45, 13);
            this.lblClassARevenueCaption.TabIndex = 0;
            this.lblClassARevenueCaption.Text = "Class A:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(160, 198);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 45);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Revenue";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(241, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 45);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(322, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 3;
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
            this.ClientSize = new System.Drawing.Size(556, 263);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpRevenue);
            this.Controls.Add(this.grpTicketsSold);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.grpTicketsSold.ResumeLayout(false);
            this.grpTicketsSold.PerformLayout();
            this.grpRevenue.ResumeLayout(false);
            this.grpRevenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTicketsSold;
        private System.Windows.Forms.GroupBox grpRevenue;
        private System.Windows.Forms.TextBox txtClassC;
        private System.Windows.Forms.TextBox txtClassA;
        private System.Windows.Forms.TextBox txtClassB;
        private System.Windows.Forms.Label lblClassCTicketsCaption;
        private System.Windows.Forms.Label lblClassBTicketsCaption;
        private System.Windows.Forms.Label lblClassATicketsCaption;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblClassCRevenue;
        private System.Windows.Forms.Label lblClassBRevenue;
        private System.Windows.Forms.Label lblClassARevenue;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblClassCRevenueCaption;
        private System.Windows.Forms.Label lblClassBRevenueCaption;
        private System.Windows.Forms.Label lblClassARevenueCaption;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

