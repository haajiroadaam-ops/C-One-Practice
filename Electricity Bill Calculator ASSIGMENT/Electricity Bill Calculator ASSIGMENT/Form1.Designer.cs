namespace Electricity_Bill_Calculator_ASSIGMENT
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPreviousReading = new System.Windows.Forms.Label();
            this.lblCurrentReading = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.btnCalculateBill = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblEBill = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(155, 98);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(186, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Enter Customer Name";
            // 
            // lblPreviousReading
            // 
            this.lblPreviousReading.AutoSize = true;
            this.lblPreviousReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousReading.Location = new System.Drawing.Point(155, 132);
            this.lblPreviousReading.Name = "lblPreviousReading";
            this.lblPreviousReading.Size = new System.Drawing.Size(198, 20);
            this.lblPreviousReading.TabIndex = 1;
            this.lblPreviousReading.Text = "Enter Previous Reading";
            // 
            // lblCurrentReading
            // 
            this.lblCurrentReading.AutoSize = true;
            this.lblCurrentReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentReading.Location = new System.Drawing.Point(155, 172);
            this.lblCurrentReading.Name = "lblCurrentReading";
            this.lblCurrentReading.Size = new System.Drawing.Size(190, 20);
            this.lblCurrentReading.TabIndex = 2;
            this.lblCurrentReading.Text = "Enter Current Reading";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.Location = new System.Drawing.Point(155, 208);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(168, 20);
            this.lblPricePerUnit.TabIndex = 3;
            this.lblPricePerUnit.Text = "Enter Price Per Unit";
            this.lblPricePerUnit.Click += new System.EventHandler(this.lblPricePerUnit_Click);
            // 
            // btnCalculateBill
            // 
            this.btnCalculateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalculateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateBill.Location = new System.Drawing.Point(303, 270);
            this.btnCalculateBill.Name = "btnCalculateBill";
            this.btnCalculateBill.Size = new System.Drawing.Size(188, 51);
            this.btnCalculateBill.TabIndex = 8;
            this.btnCalculateBill.Text = "Calculate Bill";
            this.btnCalculateBill.UseVisualStyleBackColor = false;
            this.btnCalculateBill.Click += new System.EventHandler(this.btnCalculateBill_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(128, 367);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 20);
            this.lbl.TabIndex = 9;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(159, 349);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(554, 79);
            this.lblOutput.TabIndex = 10;
            // 
            // lblEBill
            // 
            this.lblEBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblEBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEBill.Location = new System.Drawing.Point(250, 39);
            this.lblEBill.Name = "lblEBill";
            this.lblEBill.Size = new System.Drawing.Size(294, 33);
            this.lblEBill.TabIndex = 11;
            this.lblEBill.Text = "Electricity Bill Calculator";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(467, 92);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(218, 26);
            this.txtCustomer.TabIndex = 12;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(467, 208);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(218, 26);
            this.txtUnitPrice.TabIndex = 13;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(467, 172);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(218, 26);
            this.txtCurrent.TabIndex = 14;
            // 
            // txtPrevious
            // 
            this.txtPrevious.Location = new System.Drawing.Point(467, 132);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(218, 26);
            this.txtPrevious.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblEBill);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnCalculateBill);
            this.Controls.Add(this.lblPricePerUnit);
            this.Controls.Add(this.lblCurrentReading);
            this.Controls.Add(this.lblPreviousReading);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPreviousReading;
        private System.Windows.Forms.Label lblCurrentReading;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.Button btnCalculateBill;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblEBill;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtPrevious;
    }
}

