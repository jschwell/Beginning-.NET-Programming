namespace Name_Search
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
            this.lblBoyCaption = new System.Windows.Forms.Label();
            this.lblGirlCaption = new System.Windows.Forms.Label();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtGirl = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBoyCaption
            // 
            this.lblBoyCaption.AutoSize = true;
            this.lblBoyCaption.Location = new System.Drawing.Point(32, 15);
            this.lblBoyCaption.Name = "lblBoyCaption";
            this.lblBoyCaption.Size = new System.Drawing.Size(66, 13);
            this.lblBoyCaption.TabIndex = 0;
            this.lblBoyCaption.Text = "Boy\'s Name:";
            // 
            // lblGirlCaption
            // 
            this.lblGirlCaption.AutoSize = true;
            this.lblGirlCaption.Location = new System.Drawing.Point(35, 41);
            this.lblGirlCaption.Name = "lblGirlCaption";
            this.lblGirlCaption.Size = new System.Drawing.Size(63, 13);
            this.lblGirlCaption.TabIndex = 1;
            this.lblGirlCaption.Text = "Girl\'s Name:";
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(104, 12);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(139, 20);
            this.txtBoy.TabIndex = 0;
            // 
            // txtGirl
            // 
            this.txtGirl.Location = new System.Drawing.Point(104, 38);
            this.txtGirl.Name = "txtGirl";
            this.txtGirl.Size = new System.Drawing.Size(139, 20);
            this.txtGirl.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(12, 71);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(260, 54);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(23, 141);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(104, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(185, 141);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtGirl);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.lblGirlCaption);
            this.Controls.Add(this.lblBoyCaption);
            this.Name = "Form1";
            this.Text = "Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoyCaption;
        private System.Windows.Forms.Label lblGirlCaption;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtGirl;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

