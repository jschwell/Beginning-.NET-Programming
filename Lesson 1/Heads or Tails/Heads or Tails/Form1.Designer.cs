namespace Heads_or_Tails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.showHeadsButton = new System.Windows.Forms.Button();
            this.showTailsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headsPictureBox.Image")));
            this.headsPictureBox.Location = new System.Drawing.Point(12, 12);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPictureBox.TabIndex = 0;
            this.headsPictureBox.TabStop = false;
            this.headsPictureBox.Visible = false;
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tailsPictureBox.Image")));
            this.tailsPictureBox.Location = new System.Drawing.Point(201, 12);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            this.tailsPictureBox.Visible = false;
            // 
            // showHeadsButton
            // 
            this.showHeadsButton.Location = new System.Drawing.Point(70, 191);
            this.showHeadsButton.Name = "showHeadsButton";
            this.showHeadsButton.Size = new System.Drawing.Size(75, 44);
            this.showHeadsButton.TabIndex = 2;
            this.showHeadsButton.Text = "Show Heads";
            this.showHeadsButton.UseVisualStyleBackColor = true;
            this.showHeadsButton.Click += new System.EventHandler(this.showHeadsButton_Click);
            // 
            // showTailsButton
            // 
            this.showTailsButton.Location = new System.Drawing.Point(151, 191);
            this.showTailsButton.Name = "showTailsButton";
            this.showTailsButton.Size = new System.Drawing.Size(75, 44);
            this.showTailsButton.TabIndex = 3;
            this.showTailsButton.Text = "Show Tails";
            this.showTailsButton.UseVisualStyleBackColor = true;
            this.showTailsButton.Click += new System.EventHandler(this.showTailsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(232, 191);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 44);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 251);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showTailsButton);
            this.Controls.Add(this.showHeadsButton);
            this.Controls.Add(this.tailsPictureBox);
            this.Controls.Add(this.headsPictureBox);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button showHeadsButton;
        private System.Windows.Forms.Button showTailsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

