namespace Population
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
            this.lblOrganismsCaption = new System.Windows.Forms.Label();
            this.lblIncreaseCaption = new System.Windows.Forms.Label();
            this.lblDaysCaption = new System.Windows.Forms.Label();
            this.txtOrganisms = new System.Windows.Forms.TextBox();
            this.txtIncrease = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lbPopulation = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrganismsCaption
            // 
            this.lblOrganismsCaption.AutoSize = true;
            this.lblOrganismsCaption.Location = new System.Drawing.Point(12, 15);
            this.lblOrganismsCaption.Name = "lblOrganismsCaption";
            this.lblOrganismsCaption.Size = new System.Drawing.Size(146, 13);
            this.lblOrganismsCaption.TabIndex = 0;
            this.lblOrganismsCaption.Text = "Starting number of organisms:";
            // 
            // lblIncreaseCaption
            // 
            this.lblIncreaseCaption.AutoSize = true;
            this.lblIncreaseCaption.Location = new System.Drawing.Point(24, 41);
            this.lblIncreaseCaption.Name = "lblIncreaseCaption";
            this.lblIncreaseCaption.Size = new System.Drawing.Size(134, 13);
            this.lblIncreaseCaption.TabIndex = 1;
            this.lblIncreaseCaption.Text = "Average daily increase (%):";
            // 
            // lblDaysCaption
            // 
            this.lblDaysCaption.AutoSize = true;
            this.lblDaysCaption.Location = new System.Drawing.Point(25, 67);
            this.lblDaysCaption.Name = "lblDaysCaption";
            this.lblDaysCaption.Size = new System.Drawing.Size(133, 13);
            this.lblDaysCaption.TabIndex = 2;
            this.lblDaysCaption.Text = "Number of days to multiply:";
            // 
            // txtOrganisms
            // 
            this.txtOrganisms.Location = new System.Drawing.Point(164, 12);
            this.txtOrganisms.Name = "txtOrganisms";
            this.txtOrganisms.Size = new System.Drawing.Size(100, 20);
            this.txtOrganisms.TabIndex = 0;
            // 
            // txtIncrease
            // 
            this.txtIncrease.Location = new System.Drawing.Point(164, 38);
            this.txtIncrease.Name = "txtIncrease";
            this.txtIncrease.Size = new System.Drawing.Size(100, 20);
            this.txtIncrease.TabIndex = 1;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(164, 64);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 2;
            // 
            // lbPopulation
            // 
            this.lbPopulation.FormattingEnabled = true;
            this.lbPopulation.Location = new System.Drawing.Point(12, 98);
            this.lbPopulation.Name = "lbPopulation";
            this.lbPopulation.Size = new System.Drawing.Size(275, 173);
            this.lbPopulation.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(31, 294);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(112, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(193, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
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
            this.ClientSize = new System.Drawing.Size(299, 338);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbPopulation);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtIncrease);
            this.Controls.Add(this.txtOrganisms);
            this.Controls.Add(this.lblDaysCaption);
            this.Controls.Add(this.lblIncreaseCaption);
            this.Controls.Add(this.lblOrganismsCaption);
            this.Name = "Form1";
            this.Text = "Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrganismsCaption;
        private System.Windows.Forms.Label lblIncreaseCaption;
        private System.Windows.Forms.Label lblDaysCaption;
        private System.Windows.Forms.TextBox txtOrganisms;
        private System.Windows.Forms.TextBox txtIncrease;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.ListBox lbPopulation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

