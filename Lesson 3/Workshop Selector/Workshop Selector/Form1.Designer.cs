namespace Workshop_Selector
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
            this.lbWorkshop = new System.Windows.Forms.ListBox();
            this.lbLocation = new System.Windows.Forms.ListBox();
            this.lblWorkshopCaption = new System.Windows.Forms.Label();
            this.lblLocationCaption = new System.Windows.Forms.Label();
            this.lblRegistrationCaption = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblLodgingCaption = new System.Windows.Forms.Label();
            this.lblLodging = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWorkshop
            // 
            this.lbWorkshop.FormattingEnabled = true;
            this.lbWorkshop.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.lbWorkshop.Location = new System.Drawing.Point(12, 25);
            this.lbWorkshop.Name = "lbWorkshop";
            this.lbWorkshop.Size = new System.Drawing.Size(120, 82);
            this.lbWorkshop.TabIndex = 0;
            // 
            // lbLocation
            // 
            this.lbLocation.FormattingEnabled = true;
            this.lbLocation.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.lbLocation.Location = new System.Drawing.Point(152, 25);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(120, 82);
            this.lbLocation.TabIndex = 1;
            // 
            // lblWorkshopCaption
            // 
            this.lblWorkshopCaption.AutoSize = true;
            this.lblWorkshopCaption.Location = new System.Drawing.Point(12, 9);
            this.lblWorkshopCaption.Name = "lblWorkshopCaption";
            this.lblWorkshopCaption.Size = new System.Drawing.Size(98, 13);
            this.lblWorkshopCaption.TabIndex = 2;
            this.lblWorkshopCaption.Text = "Select a workshop:";
            // 
            // lblLocationCaption
            // 
            this.lblLocationCaption.AutoSize = true;
            this.lblLocationCaption.Location = new System.Drawing.Point(149, 9);
            this.lblLocationCaption.Name = "lblLocationCaption";
            this.lblLocationCaption.Size = new System.Drawing.Size(89, 13);
            this.lblLocationCaption.TabIndex = 3;
            this.lblLocationCaption.Text = "Select a location:";
            // 
            // lblRegistrationCaption
            // 
            this.lblRegistrationCaption.AutoSize = true;
            this.lblRegistrationCaption.Location = new System.Drawing.Point(33, 133);
            this.lblRegistrationCaption.Name = "lblRegistrationCaption";
            this.lblRegistrationCaption.Size = new System.Drawing.Size(90, 13);
            this.lblRegistrationCaption.TabIndex = 4;
            this.lblRegistrationCaption.Text = "Registration Cost:";
            // 
            // lblRegistration
            // 
            this.lblRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistration.Location = new System.Drawing.Point(129, 128);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(100, 23);
            this.lblRegistration.TabIndex = 5;
            this.lblRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLodgingCaption
            // 
            this.lblLodgingCaption.AutoSize = true;
            this.lblLodgingCaption.Location = new System.Drawing.Point(51, 161);
            this.lblLodgingCaption.Name = "lblLodgingCaption";
            this.lblLodgingCaption.Size = new System.Drawing.Size(72, 13);
            this.lblLodgingCaption.TabIndex = 6;
            this.lblLodgingCaption.Text = "Lodging Cost:";
            // 
            // lblLodging
            // 
            this.lblLodging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLodging.Location = new System.Drawing.Point(129, 156);
            this.lblLodging.Name = "lblLodging";
            this.lblLodging.Size = new System.Drawing.Size(100, 23);
            this.lblLodging.TabIndex = 7;
            this.lblLodging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(89, 189);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCaption.TabIndex = 8;
            this.lblTotalCaption.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(129, 184);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(106, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(187, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
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
            this.ClientSize = new System.Drawing.Size(286, 274);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalCaption);
            this.Controls.Add(this.lblLodging);
            this.Controls.Add(this.lblLodgingCaption);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.lblRegistrationCaption);
            this.Controls.Add(this.lblLocationCaption);
            this.Controls.Add(this.lblWorkshopCaption);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.lbWorkshop);
            this.Name = "Form1";
            this.Text = "Workshop Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWorkshop;
        private System.Windows.Forms.ListBox lbLocation;
        private System.Windows.Forms.Label lblWorkshopCaption;
        private System.Windows.Forms.Label lblLocationCaption;
        private System.Windows.Forms.Label lblRegistrationCaption;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblLodgingCaption;
        private System.Windows.Forms.Label lblLodging;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

