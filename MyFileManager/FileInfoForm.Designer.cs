namespace MyFileManager
{
    partial class FileInfoForm
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
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxCreated = new System.Windows.Forms.TextBox();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.labelCreated = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelDir = new System.Windows.Forms.Label();
            this.textBoxFileData = new System.Windows.Forms.TextBox();
            this.groupBoxFileData = new System.Windows.Forms.GroupBox();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxFileData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.textBoxFile);
            this.groupBoxDetails.Controls.Add(this.textBoxSize);
            this.groupBoxDetails.Controls.Add(this.textBoxCreated);
            this.groupBoxDetails.Controls.Add(this.textBoxDir);
            this.groupBoxDetails.Controls.Add(this.labelCreated);
            this.groupBoxDetails.Controls.Add(this.labelSize);
            this.groupBoxDetails.Controls.Add(this.labelFile);
            this.groupBoxDetails.Controls.Add(this.labelDir);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 230);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(358, 238);
            this.groupBoxDetails.TabIndex = 13;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFile.Location = new System.Drawing.Point(123, 84);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(223, 26);
            this.textBoxFile.TabIndex = 7;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSize.Location = new System.Drawing.Point(123, 140);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.ReadOnly = true;
            this.textBoxSize.Size = new System.Drawing.Size(223, 26);
            this.textBoxSize.TabIndex = 6;
            // 
            // textBoxCreated
            // 
            this.textBoxCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCreated.Location = new System.Drawing.Point(123, 196);
            this.textBoxCreated.Name = "textBoxCreated";
            this.textBoxCreated.ReadOnly = true;
            this.textBoxCreated.Size = new System.Drawing.Size(223, 26);
            this.textBoxCreated.TabIndex = 5;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDir.Location = new System.Drawing.Point(123, 25);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.ReadOnly = true;
            this.textBoxDir.Size = new System.Drawing.Size(223, 26);
            this.textBoxDir.TabIndex = 4;
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreated.Location = new System.Drawing.Point(6, 196);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(70, 20);
            this.labelCreated.TabIndex = 3;
            this.labelCreated.Text = "Created:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(6, 140);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(86, 20);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Size(Byte):";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFile.Location = new System.Drawing.Point(6, 84);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(38, 20);
            this.labelFile.TabIndex = 1;
            this.labelFile.Text = "File:";
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDir.Location = new System.Drawing.Point(6, 28);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(76, 20);
            this.labelDir.TabIndex = 0;
            this.labelDir.Text = "Directory:";
            // 
            // textBoxFileData
            // 
            this.textBoxFileData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFileData.Location = new System.Drawing.Point(13, 20);
            this.textBoxFileData.Multiline = true;
            this.textBoxFileData.Name = "textBoxFileData";
            this.textBoxFileData.ReadOnly = true;
            this.textBoxFileData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFileData.Size = new System.Drawing.Size(333, 176);
            this.textBoxFileData.TabIndex = 8;
            // 
            // groupBoxFileData
            // 
            this.groupBoxFileData.Controls.Add(this.textBoxFileData);
            this.groupBoxFileData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFileData.Name = "groupBoxFileData";
            this.groupBoxFileData.Size = new System.Drawing.Size(358, 212);
            this.groupBoxFileData.TabIndex = 12;
            this.groupBoxFileData.TabStop = false;
            this.groupBoxFileData.Text = "Data";
            // 
            // FileInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 481);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxFileData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 520);
            this.Name = "FileInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Info";
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxFileData.ResumeLayout(false);
            this.groupBoxFileData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxCreated;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.TextBox textBoxFileData;
        private System.Windows.Forms.GroupBox groupBoxFileData;
    }
}