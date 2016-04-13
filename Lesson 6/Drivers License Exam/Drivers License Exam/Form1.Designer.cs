namespace Drivers_License_Exam
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
            this.lblMessageCaption = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCorrectCaption = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrectCaption = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lbQuestions = new System.Windows.Forms.ListBox();
            this.lblQuestionsList = new System.Windows.Forms.Label();
            this.btnGetScore = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessageCaption
            // 
            this.lblMessageCaption.AutoSize = true;
            this.lblMessageCaption.Location = new System.Drawing.Point(151, 9);
            this.lblMessageCaption.Name = "lblMessageCaption";
            this.lblMessageCaption.Size = new System.Drawing.Size(45, 13);
            this.lblMessageCaption.TabIndex = 0;
            this.lblMessageCaption.Text = "Results:";
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(154, 25);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(100, 23);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrectCaption
            // 
            this.lblCorrectCaption.AutoSize = true;
            this.lblCorrectCaption.Location = new System.Drawing.Point(151, 52);
            this.lblCorrectCaption.Name = "lblCorrectCaption";
            this.lblCorrectCaption.Size = new System.Drawing.Size(70, 13);
            this.lblCorrectCaption.TabIndex = 2;
            this.lblCorrectCaption.Text = "Total correct:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorrect.Location = new System.Drawing.Point(154, 67);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(100, 23);
            this.lblCorrect.TabIndex = 3;
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncorrectCaption
            // 
            this.lblIncorrectCaption.AutoSize = true;
            this.lblIncorrectCaption.Location = new System.Drawing.Point(151, 95);
            this.lblIncorrectCaption.Name = "lblIncorrectCaption";
            this.lblIncorrectCaption.Size = new System.Drawing.Size(78, 13);
            this.lblIncorrectCaption.TabIndex = 4;
            this.lblIncorrectCaption.Text = "Total incorrect:";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIncorrect.Location = new System.Drawing.Point(154, 110);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(100, 23);
            this.lblIncorrect.TabIndex = 5;
            this.lblIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQuestions
            // 
            this.lbQuestions.FormattingEnabled = true;
            this.lbQuestions.Location = new System.Drawing.Point(12, 25);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(120, 108);
            this.lbQuestions.TabIndex = 6;
            // 
            // lblQuestionsList
            // 
            this.lblQuestionsList.AutoSize = true;
            this.lblQuestionsList.Location = new System.Drawing.Point(9, 9);
            this.lblQuestionsList.Name = "lblQuestionsList";
            this.lblQuestionsList.Size = new System.Drawing.Size(100, 13);
            this.lblQuestionsList.TabIndex = 7;
            this.lblQuestionsList.Text = "Incorrect questions:";
            // 
            // btnGetScore
            // 
            this.btnGetScore.Location = new System.Drawing.Point(14, 148);
            this.btnGetScore.Name = "btnGetScore";
            this.btnGetScore.Size = new System.Drawing.Size(75, 23);
            this.btnGetScore.TabIndex = 0;
            this.btnGetScore.Text = "Get Score";
            this.btnGetScore.UseVisualStyleBackColor = true;
            this.btnGetScore.Click += new System.EventHandler(this.btnGetScore_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(95, 148);
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
            this.btnExit.Location = new System.Drawing.Point(176, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetScore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(267, 184);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetScore);
            this.Controls.Add(this.lblQuestionsList);
            this.Controls.Add(this.lbQuestions);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblIncorrectCaption);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblCorrectCaption);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblMessageCaption);
            this.Name = "Form1";
            this.Text = "Driver\'s License Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessageCaption;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCorrectCaption;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrectCaption;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.ListBox lbQuestions;
        private System.Windows.Forms.Label lblQuestionsList;
        private System.Windows.Forms.Button btnGetScore;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

