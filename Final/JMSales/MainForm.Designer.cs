namespace JMSales
{
	partial class MainForm
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salesTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstbxSalesID = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstBxSalesReport = new System.Windows.Forms.ListBox();
            this.btnSaveSales = new System.Windows.Forms.Button();
            this.exitBtn1 = new System.Windows.Forms.Button();
            this.createReportBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(124, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Sales Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sales:";
            // 
            // salesTB
            // 
            this.salesTB.Location = new System.Drawing.Point(226, 34);
            this.salesTB.MaxLength = 10;
            this.salesTB.Name = "salesTB";
            this.salesTB.Size = new System.Drawing.Size(100, 20);
            this.salesTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "$";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lstbxSalesID);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.salesTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 145);
            this.panel1.TabIndex = 1;
            // 
            // lstbxSalesID
            // 
            this.lstbxSalesID.FormattingEnabled = true;
            this.lstbxSalesID.Location = new System.Drawing.Point(16, 33);
            this.lstbxSalesID.Name = "lstbxSalesID";
            this.lstbxSalesID.Size = new System.Drawing.Size(120, 95);
            this.lstbxSalesID.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addBtn.Location = new System.Drawing.Point(328, 76);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 25);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "&Add To Totals";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sales Report:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lstBxSalesReport);
            this.panel2.Controls.Add(this.btnSaveSales);
            this.panel2.Controls.Add(this.exitBtn1);
            this.panel2.Controls.Add(this.createReportBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(31, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 202);
            this.panel2.TabIndex = 2;
            // 
            // lstBxSalesReport
            // 
            this.lstBxSalesReport.FormattingEnabled = true;
            this.lstBxSalesReport.Location = new System.Drawing.Point(18, 34);
            this.lstBxSalesReport.Name = "lstBxSalesReport";
            this.lstBxSalesReport.Size = new System.Drawing.Size(286, 147);
            this.lstBxSalesReport.TabIndex = 0;
            // 
            // btnSaveSales
            // 
            this.btnSaveSales.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveSales.Location = new System.Drawing.Point(328, 96);
            this.btnSaveSales.Name = "btnSaveSales";
            this.btnSaveSales.Size = new System.Drawing.Size(100, 25);
            this.btnSaveSales.TabIndex = 2;
            this.btnSaveSales.Text = "&Save Sales to File";
            this.btnSaveSales.UseVisualStyleBackColor = true;
            this.btnSaveSales.Click += new System.EventHandler(this.btnSaveSales_Click);
            // 
            // exitBtn1
            // 
            this.exitBtn1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn1.Location = new System.Drawing.Point(328, 145);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Size = new System.Drawing.Size(100, 25);
            this.exitBtn1.TabIndex = 3;
            this.exitBtn1.Text = "E&xit";
            this.exitBtn1.UseVisualStyleBackColor = true;
            this.exitBtn1.Click += new System.EventHandler(this.exitBtn1_Click);
            // 
            // createReportBtn
            // 
            this.createReportBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createReportBtn.Location = new System.Drawing.Point(328, 47);
            this.createReportBtn.Name = "createReportBtn";
            this.createReportBtn.Size = new System.Drawing.Size(100, 25);
            this.createReportBtn.TabIndex = 1;
            this.createReportBtn.Text = "&Create Report";
            this.createReportBtn.UseVisualStyleBackColor = true;
            this.createReportBtn.Click += new System.EventHandler(this.createReportBtn_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn1;
            this.ClientSize = new System.Drawing.Size(546, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl1);
            this.Name = "MainForm";
            this.Text = "JM Sales";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox salesTB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button createReportBtn;
		private System.Windows.Forms.Button exitBtn1;
        private System.Windows.Forms.ListBox lstbxSalesID;
        private System.Windows.Forms.Button btnSaveSales;
        private System.Windows.Forms.ListBox lstBxSalesReport;
    }
}

