namespace Calories_from_Fat_and_Carbs
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
            this.lblFatGrams = new System.Windows.Forms.Label();
            this.lblCarbGrams = new System.Windows.Forms.Label();
            this.txtFatGrams = new System.Windows.Forms.TextBox();
            this.txtCarbGrams = new System.Windows.Forms.TextBox();
            this.lblFatCaloriesCaption = new System.Windows.Forms.Label();
            this.lblFatCalories = new System.Windows.Forms.Label();
            this.lblCarbCaloriesCaption = new System.Windows.Forms.Label();
            this.lblCarbCalories = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFatGrams
            // 
            this.lblFatGrams.AutoSize = true;
            this.lblFatGrams.Location = new System.Drawing.Point(63, 15);
            this.lblFatGrams.Name = "lblFatGrams";
            this.lblFatGrams.Size = new System.Drawing.Size(105, 13);
            this.lblFatGrams.TabIndex = 0;
            this.lblFatGrams.Text = "Number of fat grams:";
            // 
            // lblCarbGrams
            // 
            this.lblCarbGrams.AutoSize = true;
            this.lblCarbGrams.Location = new System.Drawing.Point(13, 41);
            this.lblCarbGrams.Name = "lblCarbGrams";
            this.lblCarbGrams.Size = new System.Drawing.Size(155, 13);
            this.lblCarbGrams.TabIndex = 1;
            this.lblCarbGrams.Text = "Number of carbohydrate grams:";
            // 
            // txtFatGrams
            // 
            this.txtFatGrams.Location = new System.Drawing.Point(174, 12);
            this.txtFatGrams.Name = "txtFatGrams";
            this.txtFatGrams.Size = new System.Drawing.Size(100, 20);
            this.txtFatGrams.TabIndex = 0;
            this.txtFatGrams.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCarbGrams
            // 
            this.txtCarbGrams.Location = new System.Drawing.Point(174, 38);
            this.txtCarbGrams.Name = "txtCarbGrams";
            this.txtCarbGrams.Size = new System.Drawing.Size(100, 20);
            this.txtCarbGrams.TabIndex = 1;
            this.txtCarbGrams.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFatCaloriesCaption
            // 
            this.lblFatCaloriesCaption.AutoSize = true;
            this.lblFatCaloriesCaption.Location = new System.Drawing.Point(83, 70);
            this.lblFatCaloriesCaption.Name = "lblFatCaloriesCaption";
            this.lblFatCaloriesCaption.Size = new System.Drawing.Size(85, 13);
            this.lblFatCaloriesCaption.TabIndex = 4;
            this.lblFatCaloriesCaption.Text = "Calories from fat:";
            // 
            // lblFatCalories
            // 
            this.lblFatCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFatCalories.Location = new System.Drawing.Point(174, 65);
            this.lblFatCalories.Name = "lblFatCalories";
            this.lblFatCalories.Size = new System.Drawing.Size(100, 23);
            this.lblFatCalories.TabIndex = 5;
            this.lblFatCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarbCaloriesCaption
            // 
            this.lblCarbCaloriesCaption.AutoSize = true;
            this.lblCarbCaloriesCaption.Location = new System.Drawing.Point(69, 101);
            this.lblCarbCaloriesCaption.Name = "lblCarbCaloriesCaption";
            this.lblCarbCaloriesCaption.Size = new System.Drawing.Size(99, 13);
            this.lblCarbCaloriesCaption.TabIndex = 6;
            this.lblCarbCaloriesCaption.Text = "Calories from carbs:";
            // 
            // lblCarbCalories
            // 
            this.lblCarbCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarbCalories.Location = new System.Drawing.Point(174, 96);
            this.lblCarbCalories.Name = "lblCarbCalories";
            this.lblCarbCalories.Size = new System.Drawing.Size(100, 23);
            this.lblCarbCalories.TabIndex = 7;
            this.lblCarbCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(25, 135);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(106, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(187, 135);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(287, 175);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblCarbCalories);
            this.Controls.Add(this.lblCarbCaloriesCaption);
            this.Controls.Add(this.lblFatCalories);
            this.Controls.Add(this.lblFatCaloriesCaption);
            this.Controls.Add(this.txtCarbGrams);
            this.Controls.Add(this.txtFatGrams);
            this.Controls.Add(this.lblCarbGrams);
            this.Controls.Add(this.lblFatGrams);
            this.Name = "Form1";
            this.Text = "Calories from Fat and Carbohydrates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFatGrams;
        private System.Windows.Forms.Label lblCarbGrams;
        private System.Windows.Forms.TextBox txtFatGrams;
        private System.Windows.Forms.TextBox txtCarbGrams;
        private System.Windows.Forms.Label lblFatCaloriesCaption;
        private System.Windows.Forms.Label lblFatCalories;
        private System.Windows.Forms.Label lblCarbCaloriesCaption;
        private System.Windows.Forms.Label lblCarbCalories;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

