namespace Random_Number_File_Writer
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.grpWrite = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtMaxCount = new System.Windows.Forms.TextBox();
            this.lblMaxCountCaption = new System.Windows.Forms.Label();
            this.grpRead = new System.Windows.Forms.GroupBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCountCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearFile = new System.Windows.Forms.Button();
            this.grpFile.SuspendLayout();
            this.grpWrite.SuspendLayout();
            this.grpRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.btnOpen);
            this.grpFile.Controls.Add(this.btnSave);
            this.grpFile.Controls.Add(this.lblFilePath);
            this.grpFile.Location = new System.Drawing.Point(12, 12);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(391, 85);
            this.grpFile.TabIndex = 0;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "File";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(302, 50);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Create File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilePath.Location = new System.Drawing.Point(17, 21);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(359, 23);
            this.lblFilePath.TabIndex = 23;
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpWrite
            // 
            this.grpWrite.Controls.Add(this.btnWrite);
            this.grpWrite.Controls.Add(this.txtMaxCount);
            this.grpWrite.Controls.Add(this.lblMaxCountCaption);
            this.grpWrite.Location = new System.Drawing.Point(12, 103);
            this.grpWrite.Name = "grpWrite";
            this.grpWrite.Size = new System.Drawing.Size(391, 60);
            this.grpWrite.TabIndex = 1;
            this.grpWrite.TabStop = false;
            this.grpWrite.Text = "Write";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(302, 22);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.Location = new System.Drawing.Point(196, 24);
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.Size = new System.Drawing.Size(100, 20);
            this.txtMaxCount.TabIndex = 0;
            // 
            // lblMaxCountCaption
            // 
            this.lblMaxCountCaption.AutoSize = true;
            this.lblMaxCountCaption.Location = new System.Drawing.Point(14, 27);
            this.lblMaxCountCaption.Name = "lblMaxCountCaption";
            this.lblMaxCountCaption.Size = new System.Drawing.Size(176, 13);
            this.lblMaxCountCaption.TabIndex = 12;
            this.lblMaxCountCaption.Text = "Number of random numbers to add: ";
            // 
            // grpRead
            // 
            this.grpRead.Controls.Add(this.btnRead);
            this.grpRead.Controls.Add(this.lblCount);
            this.grpRead.Controls.Add(this.lblCountCaption);
            this.grpRead.Controls.Add(this.lblTotal);
            this.grpRead.Controls.Add(this.lblTotalCaption);
            this.grpRead.Controls.Add(this.lbNumbers);
            this.grpRead.Location = new System.Drawing.Point(12, 169);
            this.grpRead.Name = "grpRead";
            this.grpRead.Size = new System.Drawing.Size(391, 188);
            this.grpRead.TabIndex = 2;
            this.grpRead.TabStop = false;
            this.grpRead.Text = "Read";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(271, 135);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Location = new System.Drawing.Point(242, 99);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(134, 23);
            this.lblCount.TabIndex = 26;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountCaption
            // 
            this.lblCountCaption.AutoSize = true;
            this.lblCountCaption.Location = new System.Drawing.Point(239, 86);
            this.lblCountCaption.Name = "lblCountCaption";
            this.lblCountCaption.Size = new System.Drawing.Size(140, 13);
            this.lblCountCaption.TabIndex = 25;
            this.lblCountCaption.Text = "Number of random numbers:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(242, 54);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(134, 23);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(239, 41);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(107, 13);
            this.lblTotalCaption.TabIndex = 23;
            this.lblTotalCaption.Text = "Total of the numbers:";
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(17, 24);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(205, 147);
            this.lbNumbers.TabIndex = 22;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(92, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(254, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearFile
            // 
            this.btnClearFile.Location = new System.Drawing.Point(173, 370);
            this.btnClearFile.Name = "btnClearFile";
            this.btnClearFile.Size = new System.Drawing.Size(75, 23);
            this.btnClearFile.TabIndex = 4;
            this.btnClearFile.Text = "Clear File";
            this.btnClearFile.UseVisualStyleBackColor = true;
            this.btnClearFile.Click += new System.EventHandler(this.btnClearFile_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnWrite;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(415, 408);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearFile);
            this.Controls.Add(this.grpRead);
            this.Controls.Add(this.grpWrite);
            this.Controls.Add(this.grpFile);
            this.Name = "Form1";
            this.Text = "Random Number File Writer and Reader";
            this.grpFile.ResumeLayout(false);
            this.grpWrite.ResumeLayout(false);
            this.grpWrite.PerformLayout();
            this.grpRead.ResumeLayout(false);
            this.grpRead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.GroupBox grpWrite;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtMaxCount;
        private System.Windows.Forms.Label lblMaxCountCaption;
        private System.Windows.Forms.GroupBox grpRead;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCountCaption;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearFile;
    }
}

