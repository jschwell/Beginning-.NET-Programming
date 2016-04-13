namespace Joke_and_Punch_line
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
            this.jokeLabel = new System.Windows.Forms.Label();
            this.setupButton = new System.Windows.Forms.Button();
            this.punchLineButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jokeLabel
            // 
            this.jokeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jokeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jokeLabel.Location = new System.Drawing.Point(12, 9);
            this.jokeLabel.Name = "jokeLabel";
            this.jokeLabel.Size = new System.Drawing.Size(260, 68);
            this.jokeLabel.TabIndex = 0;
            this.jokeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(24, 98);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(75, 23);
            this.setupButton.TabIndex = 1;
            this.setupButton.Text = "Setup";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // punchLineButton
            // 
            this.punchLineButton.Location = new System.Drawing.Point(105, 98);
            this.punchLineButton.Name = "punchLineButton";
            this.punchLineButton.Size = new System.Drawing.Size(75, 23);
            this.punchLineButton.TabIndex = 2;
            this.punchLineButton.Text = "Punch line";
            this.punchLineButton.UseVisualStyleBackColor = true;
            this.punchLineButton.Click += new System.EventHandler(this.punchLineButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(186, 98);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.punchLineButton);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.jokeLabel);
            this.Name = "Form1";
            this.Text = "Joke and Punch line";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label jokeLabel;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button punchLineButton;
        private System.Windows.Forms.Button exitButton;
    }
}

