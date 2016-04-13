namespace Calorie_Counter
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
            this.lblTotalCaloriesCaption = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.ibPear = new System.Windows.Forms.PictureBox();
            this.ibOrange = new System.Windows.Forms.PictureBox();
            this.ibApple = new System.Windows.Forms.PictureBox();
            this.ibBanana = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibPear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibBanana)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCaloriesCaption
            // 
            this.lblTotalCaloriesCaption.AutoSize = true;
            this.lblTotalCaloriesCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCaloriesCaption.Location = new System.Drawing.Point(311, 12);
            this.lblTotalCaloriesCaption.Name = "lblTotalCaloriesCaption";
            this.lblTotalCaloriesCaption.Size = new System.Drawing.Size(96, 15);
            this.lblTotalCaloriesCaption.TabIndex = 4;
            this.lblTotalCaloriesCaption.Text = "Total Calories";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCalories.Location = new System.Drawing.Point(289, 32);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(138, 23);
            this.lblTotalCalories.TabIndex = 5;
            this.lblTotalCalories.Text = "0";
            this.lblTotalCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPicture
            // 
            this.pnlPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPicture.Controls.Add(this.ibPear);
            this.pnlPicture.Controls.Add(this.ibOrange);
            this.pnlPicture.Controls.Add(this.ibApple);
            this.pnlPicture.Controls.Add(this.ibBanana);
            this.pnlPicture.Location = new System.Drawing.Point(12, 12);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(266, 317);
            this.pnlPicture.TabIndex = 0;
            // 
            // ibPear
            // 
            this.ibPear.Image = ((System.Drawing.Image)(resources.GetObject("ibPear.Image")));
            this.ibPear.Location = new System.Drawing.Point(134, 159);
            this.ibPear.Name = "ibPear";
            this.ibPear.Size = new System.Drawing.Size(125, 150);
            this.ibPear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibPear.TabIndex = 4;
            this.ibPear.TabStop = false;
            this.ibPear.Click += new System.EventHandler(this.ibPear_Click);
            // 
            // ibOrange
            // 
            this.ibOrange.Image = ((System.Drawing.Image)(resources.GetObject("ibOrange.Image")));
            this.ibOrange.Location = new System.Drawing.Point(3, 159);
            this.ibOrange.Name = "ibOrange";
            this.ibOrange.Size = new System.Drawing.Size(125, 150);
            this.ibOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibOrange.TabIndex = 3;
            this.ibOrange.TabStop = false;
            this.ibOrange.Click += new System.EventHandler(this.ibOrange_Click);
            // 
            // ibApple
            // 
            this.ibApple.Image = ((System.Drawing.Image)(resources.GetObject("ibApple.Image")));
            this.ibApple.Location = new System.Drawing.Point(134, 3);
            this.ibApple.Name = "ibApple";
            this.ibApple.Size = new System.Drawing.Size(125, 150);
            this.ibApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibApple.TabIndex = 2;
            this.ibApple.TabStop = false;
            this.ibApple.Click += new System.EventHandler(this.ibApple_Click);
            // 
            // ibBanana
            // 
            this.ibBanana.Image = ((System.Drawing.Image)(resources.GetObject("ibBanana.Image")));
            this.ibBanana.Location = new System.Drawing.Point(3, 3);
            this.ibBanana.Name = "ibBanana";
            this.ibBanana.Size = new System.Drawing.Size(125, 150);
            this.ibBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibBanana.TabIndex = 1;
            this.ibBanana.TabStop = false;
            this.ibBanana.Click += new System.EventHandler(this.ibBanana_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(323, 277);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(323, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(439, 342);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pnlPicture);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.lblTotalCaloriesCaption);
            this.Name = "Form1";
            this.Text = "Calorie Counter";
            this.pnlPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibPear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibBanana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCaloriesCaption;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.PictureBox ibPear;
        private System.Windows.Forms.PictureBox ibOrange;
        private System.Windows.Forms.PictureBox ibApple;
        private System.Windows.Forms.PictureBox ibBanana;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

