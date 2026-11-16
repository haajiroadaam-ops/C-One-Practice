namespace Fat_Percentage_Calculator
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
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtFatGram = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chbLowFat = new System.Windows.Forms.CheckBox();
            this.ChecklowFat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(350, 55);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(249, 26);
            this.txtColor.TabIndex = 0;
            // 
            // txtFatGram
            // 
            this.txtFatGram.Location = new System.Drawing.Point(350, 106);
            this.txtFatGram.Name = "txtFatGram";
            this.txtFatGram.Size = new System.Drawing.Size(249, 26);
            this.txtFatGram.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(32, 55);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(243, 29);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Number Of Color";
            this.lblNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(32, 106);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(157, 20);
            this.lblPercentage.TabIndex = 3;
            this.lblPercentage.Text = "Percentage Of Fat";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(277, 322);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(204, 55);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Color";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chbLowFat
            // 
            this.chbLowFat.AutoSize = true;
            this.chbLowFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLowFat.Location = new System.Drawing.Point(36, 199);
            this.chbLowFat.Name = "chbLowFat";
            this.chbLowFat.Size = new System.Drawing.Size(114, 29);
            this.chbLowFat.TabIndex = 5;
            this.chbLowFat.Text = "Low Fat";
            this.chbLowFat.UseVisualStyleBackColor = true;
            // 
            // ChecklowFat
            // 
            this.ChecklowFat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChecklowFat.Location = new System.Drawing.Point(173, 176);
            this.ChecklowFat.Name = "ChecklowFat";
            this.ChecklowFat.Size = new System.Drawing.Size(375, 96);
            this.ChecklowFat.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChecklowFat);
            this.Controls.Add(this.chbLowFat);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtFatGram);
            this.Controls.Add(this.txtColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtFatGram;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chbLowFat;
        private System.Windows.Forms.Label ChecklowFat;
    }
}

