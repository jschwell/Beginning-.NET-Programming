namespace Population_Data
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
            this.lblAverageCaption = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblGreatestCaption = new System.Windows.Forms.Label();
            this.lblGreatest = new System.Windows.Forms.Label();
            this.lblLeastCaption = new System.Windows.Forms.Label();
            this.lblLeast = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAverageCaption
            // 
            this.lblAverageCaption.AutoSize = true;
            this.lblAverageCaption.Location = new System.Drawing.Point(27, 43);
            this.lblAverageCaption.Name = "lblAverageCaption";
            this.lblAverageCaption.Size = new System.Drawing.Size(126, 13);
            this.lblAverageCaption.TabIndex = 0;
            this.lblAverageCaption.Text = "Average Annual Change:";
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(159, 38);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(113, 23);
            this.lblAverage.TabIndex = 1;
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreatestCaption
            // 
            this.lblGreatestCaption.AutoSize = true;
            this.lblGreatestCaption.Location = new System.Drawing.Point(12, 71);
            this.lblGreatestCaption.Name = "lblGreatestCaption";
            this.lblGreatestCaption.Size = new System.Drawing.Size(141, 13);
            this.lblGreatestCaption.TabIndex = 2;
            this.lblGreatestCaption.Text = "Year with Greatest Increase:";
            // 
            // lblGreatest
            // 
            this.lblGreatest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGreatest.Location = new System.Drawing.Point(159, 66);
            this.lblGreatest.Name = "lblGreatest";
            this.lblGreatest.Size = new System.Drawing.Size(113, 23);
            this.lblGreatest.TabIndex = 3;
            this.lblGreatest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeastCaption
            // 
            this.lblLeastCaption.AutoSize = true;
            this.lblLeastCaption.Location = new System.Drawing.Point(26, 99);
            this.lblLeastCaption.Name = "lblLeastCaption";
            this.lblLeastCaption.Size = new System.Drawing.Size(127, 13);
            this.lblLeastCaption.TabIndex = 4;
            this.lblLeastCaption.Text = "Year with Least Increase:";
            // 
            // lblLeast
            // 
            this.lblLeast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeast.Location = new System.Drawing.Point(159, 94);
            this.lblLeast.Name = "lblLeast";
            this.lblLeast.Size = new System.Drawing.Size(113, 23);
            this.lblLeast.TabIndex = 5;
            this.lblLeast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(57, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(170, 13);
            this.lblCaption.TabIndex = 6;
            this.lblCaption.Text = "1950 - 1990 Population Data";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(24, 134);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(105, 134);
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
            this.btnExit.Location = new System.Drawing.Point(186, 134);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lblLeast);
            this.Controls.Add(this.lblLeastCaption);
            this.Controls.Add(this.lblGreatest);
            this.Controls.Add(this.lblGreatestCaption);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblAverageCaption);
            this.Name = "Form1";
            this.Text = "Population Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAverageCaption;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblGreatestCaption;
        private System.Windows.Forms.Label lblGreatest;
        private System.Windows.Forms.Label lblLeastCaption;
        private System.Windows.Forms.Label lblLeast;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

