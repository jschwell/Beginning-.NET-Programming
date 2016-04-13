namespace Orion_Constellation
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
            this.orionPictureBox = new System.Windows.Forms.PictureBox();
            this.showStarNamesButton = new System.Windows.Forms.Button();
            this.hideStarNamesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.betelgeuseLabel = new System.Windows.Forms.Label();
            this.meissaLabel = new System.Windows.Forms.Label();
            this.mintakaLabel = new System.Windows.Forms.Label();
            this.rigelLabel = new System.Windows.Forms.Label();
            this.alnilamLabel = new System.Windows.Forms.Label();
            this.alnitakLabel = new System.Windows.Forms.Label();
            this.saiphLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orionPictureBox
            // 
            this.orionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("orionPictureBox.Image")));
            this.orionPictureBox.Location = new System.Drawing.Point(12, 12);
            this.orionPictureBox.Name = "orionPictureBox";
            this.orionPictureBox.Size = new System.Drawing.Size(357, 422);
            this.orionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orionPictureBox.TabIndex = 0;
            this.orionPictureBox.TabStop = false;
            // 
            // showStarNamesButton
            // 
            this.showStarNamesButton.Location = new System.Drawing.Point(69, 449);
            this.showStarNamesButton.Name = "showStarNamesButton";
            this.showStarNamesButton.Size = new System.Drawing.Size(75, 40);
            this.showStarNamesButton.TabIndex = 1;
            this.showStarNamesButton.Text = "Show Star Names";
            this.showStarNamesButton.UseVisualStyleBackColor = true;
            this.showStarNamesButton.Click += new System.EventHandler(this.showStarNamesButton_Click);
            // 
            // hideStarNamesButton
            // 
            this.hideStarNamesButton.Location = new System.Drawing.Point(150, 449);
            this.hideStarNamesButton.Name = "hideStarNamesButton";
            this.hideStarNamesButton.Size = new System.Drawing.Size(75, 40);
            this.hideStarNamesButton.TabIndex = 2;
            this.hideStarNamesButton.Text = "Hide Star Names";
            this.hideStarNamesButton.UseVisualStyleBackColor = true;
            this.hideStarNamesButton.Click += new System.EventHandler(this.hideStarNamesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(231, 449);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // betelgeuseLabel
            // 
            this.betelgeuseLabel.AutoSize = true;
            this.betelgeuseLabel.Location = new System.Drawing.Point(56, 40);
            this.betelgeuseLabel.Name = "betelgeuseLabel";
            this.betelgeuseLabel.Size = new System.Drawing.Size(60, 13);
            this.betelgeuseLabel.TabIndex = 4;
            this.betelgeuseLabel.Text = "Betelgeuse";
            this.betelgeuseLabel.Visible = false;
            // 
            // meissaLabel
            // 
            this.meissaLabel.AutoSize = true;
            this.meissaLabel.Location = new System.Drawing.Point(240, 73);
            this.meissaLabel.Name = "meissaLabel";
            this.meissaLabel.Size = new System.Drawing.Size(40, 13);
            this.meissaLabel.TabIndex = 5;
            this.meissaLabel.Text = "Meissa";
            this.meissaLabel.Visible = false;
            // 
            // mintakaLabel
            // 
            this.mintakaLabel.AutoSize = true;
            this.mintakaLabel.Location = new System.Drawing.Point(219, 192);
            this.mintakaLabel.Name = "mintakaLabel";
            this.mintakaLabel.Size = new System.Drawing.Size(45, 13);
            this.mintakaLabel.TabIndex = 6;
            this.mintakaLabel.Text = "Mintaka";
            this.mintakaLabel.Visible = false;
            // 
            // rigelLabel
            // 
            this.rigelLabel.AutoSize = true;
            this.rigelLabel.Location = new System.Drawing.Point(245, 331);
            this.rigelLabel.Name = "rigelLabel";
            this.rigelLabel.Size = new System.Drawing.Size(31, 13);
            this.rigelLabel.TabIndex = 7;
            this.rigelLabel.Text = "Rigel";
            this.rigelLabel.Visible = false;
            // 
            // alnilamLabel
            // 
            this.alnilamLabel.AutoSize = true;
            this.alnilamLabel.Location = new System.Drawing.Point(155, 219);
            this.alnilamLabel.Name = "alnilamLabel";
            this.alnilamLabel.Size = new System.Drawing.Size(40, 13);
            this.alnilamLabel.TabIndex = 8;
            this.alnilamLabel.Text = "Alnilam";
            this.alnilamLabel.Visible = false;
            // 
            // alnitakLabel
            // 
            this.alnitakLabel.AutoSize = true;
            this.alnitakLabel.Location = new System.Drawing.Point(81, 221);
            this.alnitakLabel.Name = "alnitakLabel";
            this.alnitakLabel.Size = new System.Drawing.Size(39, 13);
            this.alnitakLabel.TabIndex = 9;
            this.alnitakLabel.Text = "Alnitak";
            this.alnitakLabel.Visible = false;
            // 
            // saiphLabel
            // 
            this.saiphLabel.AutoSize = true;
            this.saiphLabel.Location = new System.Drawing.Point(74, 359);
            this.saiphLabel.Name = "saiphLabel";
            this.saiphLabel.Size = new System.Drawing.Size(34, 13);
            this.saiphLabel.TabIndex = 10;
            this.saiphLabel.Text = "Saiph";
            this.saiphLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 502);
            this.Controls.Add(this.saiphLabel);
            this.Controls.Add(this.alnitakLabel);
            this.Controls.Add(this.alnilamLabel);
            this.Controls.Add(this.rigelLabel);
            this.Controls.Add(this.mintakaLabel);
            this.Controls.Add(this.meissaLabel);
            this.Controls.Add(this.betelgeuseLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hideStarNamesButton);
            this.Controls.Add(this.showStarNamesButton);
            this.Controls.Add(this.orionPictureBox);
            this.Name = "Form1";
            this.Text = "Orion Constellation";
            ((System.ComponentModel.ISupportInitialize)(this.orionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orionPictureBox;
        private System.Windows.Forms.Button showStarNamesButton;
        private System.Windows.Forms.Button hideStarNamesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label betelgeuseLabel;
        private System.Windows.Forms.Label meissaLabel;
        private System.Windows.Forms.Label mintakaLabel;
        private System.Windows.Forms.Label rigelLabel;
        private System.Windows.Forms.Label alnilamLabel;
        private System.Windows.Forms.Label alnitakLabel;
        private System.Windows.Forms.Label saiphLabel;
    }
}

