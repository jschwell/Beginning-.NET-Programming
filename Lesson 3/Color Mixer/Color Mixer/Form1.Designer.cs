namespace Color_Mixer
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
            this.grpFirstColor = new System.Windows.Forms.GroupBox();
            this.rbFirstYellow = new System.Windows.Forms.RadioButton();
            this.rbFirstBlue = new System.Windows.Forms.RadioButton();
            this.rbFirstRed = new System.Windows.Forms.RadioButton();
            this.grpSecondColor = new System.Windows.Forms.GroupBox();
            this.rbSecondYellow = new System.Windows.Forms.RadioButton();
            this.rbSecondBlue = new System.Windows.Forms.RadioButton();
            this.rbSecondRed = new System.Windows.Forms.RadioButton();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpFirstColor.SuspendLayout();
            this.grpSecondColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFirstColor
            // 
            this.grpFirstColor.Controls.Add(this.rbFirstYellow);
            this.grpFirstColor.Controls.Add(this.rbFirstBlue);
            this.grpFirstColor.Controls.Add(this.rbFirstRed);
            this.grpFirstColor.Location = new System.Drawing.Point(12, 12);
            this.grpFirstColor.Name = "grpFirstColor";
            this.grpFirstColor.Size = new System.Drawing.Size(140, 96);
            this.grpFirstColor.TabIndex = 0;
            this.grpFirstColor.TabStop = false;
            this.grpFirstColor.Text = "Select the First Color";
            // 
            // rbFirstYellow
            // 
            this.rbFirstYellow.AutoSize = true;
            this.rbFirstYellow.Location = new System.Drawing.Point(42, 65);
            this.rbFirstYellow.Name = "rbFirstYellow";
            this.rbFirstYellow.Size = new System.Drawing.Size(56, 17);
            this.rbFirstYellow.TabIndex = 2;
            this.rbFirstYellow.Text = "Yellow";
            this.rbFirstYellow.UseVisualStyleBackColor = true;
            // 
            // rbFirstBlue
            // 
            this.rbFirstBlue.AutoSize = true;
            this.rbFirstBlue.Location = new System.Drawing.Point(42, 42);
            this.rbFirstBlue.Name = "rbFirstBlue";
            this.rbFirstBlue.Size = new System.Drawing.Size(46, 17);
            this.rbFirstBlue.TabIndex = 1;
            this.rbFirstBlue.Text = "Blue";
            this.rbFirstBlue.UseVisualStyleBackColor = true;
            // 
            // rbFirstRed
            // 
            this.rbFirstRed.AutoSize = true;
            this.rbFirstRed.Checked = true;
            this.rbFirstRed.Location = new System.Drawing.Point(42, 19);
            this.rbFirstRed.Name = "rbFirstRed";
            this.rbFirstRed.Size = new System.Drawing.Size(45, 17);
            this.rbFirstRed.TabIndex = 0;
            this.rbFirstRed.TabStop = true;
            this.rbFirstRed.Text = "Red";
            this.rbFirstRed.UseVisualStyleBackColor = true;
            // 
            // grpSecondColor
            // 
            this.grpSecondColor.Controls.Add(this.rbSecondYellow);
            this.grpSecondColor.Controls.Add(this.rbSecondBlue);
            this.grpSecondColor.Controls.Add(this.rbSecondRed);
            this.grpSecondColor.Location = new System.Drawing.Point(172, 12);
            this.grpSecondColor.Name = "grpSecondColor";
            this.grpSecondColor.Size = new System.Drawing.Size(145, 96);
            this.grpSecondColor.TabIndex = 0;
            this.grpSecondColor.TabStop = false;
            this.grpSecondColor.Text = "Select the Second Color";
            // 
            // rbSecondYellow
            // 
            this.rbSecondYellow.AutoSize = true;
            this.rbSecondYellow.Location = new System.Drawing.Point(43, 65);
            this.rbSecondYellow.Name = "rbSecondYellow";
            this.rbSecondYellow.Size = new System.Drawing.Size(56, 17);
            this.rbSecondYellow.TabIndex = 2;
            this.rbSecondYellow.Text = "Yellow";
            this.rbSecondYellow.UseVisualStyleBackColor = true;
            // 
            // rbSecondBlue
            // 
            this.rbSecondBlue.AutoSize = true;
            this.rbSecondBlue.Location = new System.Drawing.Point(43, 42);
            this.rbSecondBlue.Name = "rbSecondBlue";
            this.rbSecondBlue.Size = new System.Drawing.Size(46, 17);
            this.rbSecondBlue.TabIndex = 1;
            this.rbSecondBlue.Text = "Blue";
            this.rbSecondBlue.UseVisualStyleBackColor = true;
            // 
            // rbSecondRed
            // 
            this.rbSecondRed.AutoSize = true;
            this.rbSecondRed.Checked = true;
            this.rbSecondRed.Location = new System.Drawing.Point(43, 19);
            this.rbSecondRed.Name = "rbSecondRed";
            this.rbSecondRed.Size = new System.Drawing.Size(45, 17);
            this.rbSecondRed.TabIndex = 0;
            this.rbSecondRed.TabStop = true;
            this.rbSecondRed.Text = "Red";
            this.rbSecondRed.UseVisualStyleBackColor = true;
            // 
            // btnMix
            // 
            this.btnMix.Location = new System.Drawing.Point(84, 129);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(75, 23);
            this.btnMix.TabIndex = 1;
            this.btnMix.Text = "Mix";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(165, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMix;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(330, 169);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.grpSecondColor);
            this.Controls.Add(this.grpFirstColor);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.grpFirstColor.ResumeLayout(false);
            this.grpFirstColor.PerformLayout();
            this.grpSecondColor.ResumeLayout(false);
            this.grpSecondColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFirstColor;
        private System.Windows.Forms.RadioButton rbFirstYellow;
        private System.Windows.Forms.RadioButton rbFirstBlue;
        private System.Windows.Forms.RadioButton rbFirstRed;
        private System.Windows.Forms.GroupBox grpSecondColor;
        private System.Windows.Forms.RadioButton rbSecondYellow;
        private System.Windows.Forms.RadioButton rbSecondBlue;
        private System.Windows.Forms.RadioButton rbSecondRed;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnExit;
    }
}

