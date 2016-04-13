namespace Card_Identifier
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.queenHeartsPictureBox = new System.Windows.Forms.PictureBox();
            this.aceSpadesPictureBox = new System.Windows.Forms.PictureBox();
            this.tenDiamondsPictureBox = new System.Windows.Forms.PictureBox();
            this.twoClubsPictureBox = new System.Windows.Forms.PictureBox();
            this.jackDiamondsPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.queenHeartsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDiamondsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoClubsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jackDiamondsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(182, 13);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(178, 16);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Click a Card to See Its Name";
            // 
            // queenHeartsPictureBox
            // 
            this.queenHeartsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("queenHeartsPictureBox.Image")));
            this.queenHeartsPictureBox.Location = new System.Drawing.Point(12, 41);
            this.queenHeartsPictureBox.Name = "queenHeartsPictureBox";
            this.queenHeartsPictureBox.Size = new System.Drawing.Size(100, 140);
            this.queenHeartsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queenHeartsPictureBox.TabIndex = 1;
            this.queenHeartsPictureBox.TabStop = false;
            this.queenHeartsPictureBox.Click += new System.EventHandler(this.queenHeartsPictureBox_Click);
            // 
            // aceSpadesPictureBox
            // 
            this.aceSpadesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("aceSpadesPictureBox.Image")));
            this.aceSpadesPictureBox.Location = new System.Drawing.Point(118, 41);
            this.aceSpadesPictureBox.Name = "aceSpadesPictureBox";
            this.aceSpadesPictureBox.Size = new System.Drawing.Size(100, 140);
            this.aceSpadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceSpadesPictureBox.TabIndex = 2;
            this.aceSpadesPictureBox.TabStop = false;
            this.aceSpadesPictureBox.Click += new System.EventHandler(this.aceSpadesPictureBox_Click);
            // 
            // tenDiamondsPictureBox
            // 
            this.tenDiamondsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tenDiamondsPictureBox.Image")));
            this.tenDiamondsPictureBox.Location = new System.Drawing.Point(224, 41);
            this.tenDiamondsPictureBox.Name = "tenDiamondsPictureBox";
            this.tenDiamondsPictureBox.Size = new System.Drawing.Size(100, 140);
            this.tenDiamondsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenDiamondsPictureBox.TabIndex = 3;
            this.tenDiamondsPictureBox.TabStop = false;
            this.tenDiamondsPictureBox.Click += new System.EventHandler(this.tenDiamondsPictureBox_Click);
            // 
            // twoClubsPictureBox
            // 
            this.twoClubsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("twoClubsPictureBox.Image")));
            this.twoClubsPictureBox.Location = new System.Drawing.Point(330, 41);
            this.twoClubsPictureBox.Name = "twoClubsPictureBox";
            this.twoClubsPictureBox.Size = new System.Drawing.Size(100, 140);
            this.twoClubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twoClubsPictureBox.TabIndex = 4;
            this.twoClubsPictureBox.TabStop = false;
            this.twoClubsPictureBox.Click += new System.EventHandler(this.twoClubsPictureBox_Click);
            // 
            // jackDiamondsPictureBox
            // 
            this.jackDiamondsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("jackDiamondsPictureBox.Image")));
            this.jackDiamondsPictureBox.Location = new System.Drawing.Point(435, 41);
            this.jackDiamondsPictureBox.Name = "jackDiamondsPictureBox";
            this.jackDiamondsPictureBox.Size = new System.Drawing.Size(100, 140);
            this.jackDiamondsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jackDiamondsPictureBox.TabIndex = 5;
            this.jackDiamondsPictureBox.TabStop = false;
            this.jackDiamondsPictureBox.Click += new System.EventHandler(this.jackDiamondsPictureBox_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(237, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 196);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(523, 23);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 270);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.jackDiamondsPictureBox);
            this.Controls.Add(this.twoClubsPictureBox);
            this.Controls.Add(this.tenDiamondsPictureBox);
            this.Controls.Add(this.aceSpadesPictureBox);
            this.Controls.Add(this.queenHeartsPictureBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.queenHeartsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDiamondsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoClubsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jackDiamondsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox queenHeartsPictureBox;
        private System.Windows.Forms.PictureBox aceSpadesPictureBox;
        private System.Windows.Forms.PictureBox tenDiamondsPictureBox;
        private System.Windows.Forms.PictureBox twoClubsPictureBox;
        private System.Windows.Forms.PictureBox jackDiamondsPictureBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label nameLabel;
    }
}

