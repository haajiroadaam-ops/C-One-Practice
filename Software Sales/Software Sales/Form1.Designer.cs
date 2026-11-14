namespace Software_Sales
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
            this.lbPurchaceInfo = new System.Windows.Forms.Label();
            this.NumberOfPackages = new System.Windows.Forms.Label();
            this.PricePerrPackages = new System.Windows.Forms.Label();
            this.txtNumberOfPackages = new System.Windows.Forms.TextBox();
            this.txtPricePerrPackages = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PurchaseResults = new System.Windows.Forms.ListBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPurchaceInfo
            // 
            this.lbPurchaceInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbPurchaceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPurchaceInfo.Location = new System.Drawing.Point(3, 9);
            this.lbPurchaceInfo.Name = "lbPurchaceInfo";
            this.lbPurchaceInfo.Size = new System.Drawing.Size(1038, 69);
            this.lbPurchaceInfo.TabIndex = 0;
            this.lbPurchaceInfo.Text = "1.Purchace Information";
            this.lbPurchaceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumberOfPackages
            // 
            this.NumberOfPackages.AutoSize = true;
            this.NumberOfPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPackages.Location = new System.Drawing.Point(41, 109);
            this.NumberOfPackages.Name = "NumberOfPackages";
            this.NumberOfPackages.Size = new System.Drawing.Size(205, 22);
            this.NumberOfPackages.TabIndex = 1;
            this.NumberOfPackages.Text = "Number Of Packages:";
            // 
            // PricePerrPackages
            // 
            this.PricePerrPackages.AutoSize = true;
            this.PricePerrPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePerrPackages.Location = new System.Drawing.Point(41, 160);
            this.PricePerrPackages.Name = "PricePerrPackages";
            this.PricePerrPackages.Size = new System.Drawing.Size(193, 22);
            this.PricePerrPackages.TabIndex = 2;
            this.PricePerrPackages.Text = "Price PerrPackages:";
            // 
            // txtNumberOfPackages
            // 
            this.txtNumberOfPackages.Location = new System.Drawing.Point(315, 104);
            this.txtNumberOfPackages.Name = "txtNumberOfPackages";
            this.txtNumberOfPackages.Size = new System.Drawing.Size(256, 26);
            this.txtNumberOfPackages.TabIndex = 3;
            // 
            // txtPricePerrPackages
            // 
            this.txtPricePerrPackages.Location = new System.Drawing.Point(315, 160);
            this.txtPricePerrPackages.Name = "txtPricePerrPackages";
            this.txtPricePerrPackages.Size = new System.Drawing.Size(256, 26);
            this.txtPricePerrPackages.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(58, 298);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 49);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(236, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 49);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(440, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 49);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // PurchaseResults
            // 
            this.PurchaseResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseResults.FormattingEnabled = true;
            this.PurchaseResults.ItemHeight = 29;
            this.PurchaseResults.Location = new System.Drawing.Point(642, 109);
            this.PurchaseResults.Name = "PurchaseResults";
            this.PurchaseResults.Size = new System.Drawing.Size(566, 555);
            this.PurchaseResults.TabIndex = 8;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(45, 209);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 26);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(315, 208);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(256, 26);
            this.txtAge.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1357, 671);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.PurchaseResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPricePerrPackages);
            this.Controls.Add(this.txtNumberOfPackages);
            this.Controls.Add(this.PricePerrPackages);
            this.Controls.Add(this.NumberOfPackages);
            this.Controls.Add(this.lbPurchaceInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPurchaceInfo;
        private System.Windows.Forms.Label NumberOfPackages;
        private System.Windows.Forms.Label PricePerrPackages;
        private System.Windows.Forms.TextBox txtNumberOfPackages;
        private System.Windows.Forms.TextBox txtPricePerrPackages;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox PurchaseResults;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
    }
}

