namespace Rock_Paper_Scissors_Game
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
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblComputerChoiceCaption = new System.Windows.Forms.Label();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.lblPlayerChoiceCaption = new System.Windows.Forms.Label();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // picRock
            // 
            this.picRock.Image = ((System.Drawing.Image)(resources.GetObject("picRock.Image")));
            this.picRock.Location = new System.Drawing.Point(12, 32);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(64, 64);
            this.picRock.TabIndex = 0;
            this.picRock.TabStop = false;
            this.picRock.Click += new System.EventHandler(this.picRock_Click);
            // 
            // picPaper
            // 
            this.picPaper.Image = ((System.Drawing.Image)(resources.GetObject("picPaper.Image")));
            this.picPaper.Location = new System.Drawing.Point(82, 32);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(64, 64);
            this.picPaper.TabIndex = 1;
            this.picPaper.TabStop = false;
            this.picPaper.Click += new System.EventHandler(this.picPaper_Click);
            // 
            // picScissors
            // 
            this.picScissors.Image = ((System.Drawing.Image)(resources.GetObject("picScissors.Image")));
            this.picScissors.Location = new System.Drawing.Point(152, 32);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(64, 64);
            this.picScissors.TabIndex = 2;
            this.picScissors.TabStop = false;
            this.picScissors.Click += new System.EventHandler(this.picScissors_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(20, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(188, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Select Rock, Paper, or Scissors";
            // 
            // lblOutcome
            // 
            this.lblOutcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutcome.Location = new System.Drawing.Point(12, 173);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(204, 37);
            this.lblOutcome.TabIndex = 4;
            this.lblOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerChoiceCaption
            // 
            this.lblComputerChoiceCaption.AutoSize = true;
            this.lblComputerChoiceCaption.Location = new System.Drawing.Point(12, 141);
            this.lblComputerChoiceCaption.Name = "lblComputerChoiceCaption";
            this.lblComputerChoiceCaption.Size = new System.Drawing.Size(98, 13);
            this.lblComputerChoiceCaption.TabIndex = 5;
            this.lblComputerChoiceCaption.Text = "Computer\'s Choice:";
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComputerChoice.Location = new System.Drawing.Point(116, 136);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(100, 23);
            this.lblComputerChoice.TabIndex = 6;
            this.lblComputerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerChoiceCaption
            // 
            this.lblPlayerChoiceCaption.AutoSize = true;
            this.lblPlayerChoiceCaption.Location = new System.Drawing.Point(42, 109);
            this.lblPlayerChoiceCaption.Name = "lblPlayerChoiceCaption";
            this.lblPlayerChoiceCaption.Size = new System.Drawing.Size(68, 13);
            this.lblPlayerChoiceCaption.TabIndex = 7;
            this.lblPlayerChoiceCaption.Text = "Your Choice:";
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerChoice.Location = new System.Drawing.Point(116, 104);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(100, 23);
            this.lblPlayerChoice.TabIndex = 8;
            this.lblPlayerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(36, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(117, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(228, 257);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.lblPlayerChoiceCaption);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.lblComputerChoiceCaption);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.picRock);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblComputerChoiceCaption;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblPlayerChoiceCaption;
        private System.Windows.Forms.Label lblPlayerChoice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

