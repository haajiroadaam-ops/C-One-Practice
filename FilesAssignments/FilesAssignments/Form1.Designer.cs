namespace FilesAssignments
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
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnReadLines = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnClearContents = new System.Windows.Forms.Button();
            this.lstFileContents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.BackColor = System.Drawing.Color.Purple;
            this.btnCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.ForeColor = System.Drawing.Color.White;
            this.btnCreateFile.Location = new System.Drawing.Point(220, 45);
            this.btnCreateFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(218, 114);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = false;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnReadLines
            // 
            this.btnReadLines.BackColor = System.Drawing.Color.Purple;
            this.btnReadLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadLines.ForeColor = System.Drawing.Color.White;
            this.btnReadLines.Location = new System.Drawing.Point(510, 45);
            this.btnReadLines.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReadLines.Name = "btnReadLines";
            this.btnReadLines.Size = new System.Drawing.Size(218, 114);
            this.btnReadLines.TabIndex = 1;
            this.btnReadLines.Text = "Read File";
            this.btnReadLines.UseVisualStyleBackColor = false;
            this.btnReadLines.Click += new System.EventHandler(this.btnReadLines_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.Color.Navy;
            this.btnDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFile.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFile.Location = new System.Drawing.Point(220, 185);
            this.btnDeleteFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(218, 74);
            this.btnDeleteFile.TabIndex = 2;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnClearContents
            // 
            this.btnClearContents.BackColor = System.Drawing.Color.Navy;
            this.btnClearContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearContents.ForeColor = System.Drawing.Color.White;
            this.btnClearContents.Location = new System.Drawing.Point(510, 185);
            this.btnClearContents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearContents.Name = "btnClearContents";
            this.btnClearContents.Size = new System.Drawing.Size(218, 74);
            this.btnClearContents.TabIndex = 3;
            this.btnClearContents.Text = "Clear File Contents";
            this.btnClearContents.UseVisualStyleBackColor = false;
            this.btnClearContents.Click += new System.EventHandler(this.btnClearContents_Click);
            // 
            // lstFileContents
            // 
            this.lstFileContents.FormattingEnabled = true;
            this.lstFileContents.ItemHeight = 20;
            this.lstFileContents.Location = new System.Drawing.Point(159, 299);
            this.lstFileContents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstFileContents.Name = "lstFileContents";
            this.lstFileContents.Size = new System.Drawing.Size(627, 224);
            this.lstFileContents.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 562);
            this.Controls.Add(this.lstFileContents);
            this.Controls.Add(this.btnClearContents);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnReadLines);
            this.Controls.Add(this.btnCreateFile);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnReadLines;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnClearContents;
        private System.Windows.Forms.ListBox lstFileContents;
    }
}

