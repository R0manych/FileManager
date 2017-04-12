namespace MyFileManager
{
    partial class FolderInfoForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelContains = new System.Windows.Forms.Label();
            this.labelCreated = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxCreated = new System.Windows.Forms.TextBox();
            this.textBoxContains = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBoxAttributes = new System.Windows.Forms.GroupBox();
            this.checkBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxHidden = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBoxAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(110, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(223, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // labelContains
            // 
            this.labelContains.AutoSize = true;
            this.labelContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContains.Location = new System.Drawing.Point(12, 127);
            this.labelContains.Name = "labelContains";
            this.labelContains.Size = new System.Drawing.Size(76, 20);
            this.labelContains.TabIndex = 8;
            this.labelContains.Text = "Contains:";
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreated.Location = new System.Drawing.Point(12, 188);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(70, 20);
            this.labelCreated.TabIndex = 9;
            this.labelCreated.Text = "Created:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.Location = new System.Drawing.Point(12, 69);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(42, 20);
            this.labelPath.TabIndex = 10;
            this.labelPath.Text = "Path";
            // 
            // textBoxCreated
            // 
            this.textBoxCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCreated.Location = new System.Drawing.Point(109, 188);
            this.textBoxCreated.Name = "textBoxCreated";
            this.textBoxCreated.ReadOnly = true;
            this.textBoxCreated.Size = new System.Drawing.Size(223, 26);
            this.textBoxCreated.TabIndex = 11;
            // 
            // textBoxContains
            // 
            this.textBoxContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxContains.Location = new System.Drawing.Point(110, 127);
            this.textBoxContains.Name = "textBoxContains";
            this.textBoxContains.ReadOnly = true;
            this.textBoxContains.Size = new System.Drawing.Size(223, 26);
            this.textBoxContains.TabIndex = 13;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPath.Location = new System.Drawing.Point(110, 69);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(223, 26);
            this.textBoxPath.TabIndex = 15;
            // 
            // groupBoxAttributes
            // 
            this.groupBoxAttributes.Controls.Add(this.checkBoxHidden);
            this.groupBoxAttributes.Controls.Add(this.checkBoxReadOnly);
            this.groupBoxAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAttributes.Location = new System.Drawing.Point(16, 235);
            this.groupBoxAttributes.Name = "groupBoxAttributes";
            this.groupBoxAttributes.Size = new System.Drawing.Size(317, 50);
            this.groupBoxAttributes.TabIndex = 16;
            this.groupBoxAttributes.TabStop = false;
            this.groupBoxAttributes.Text = "Attributes";
            // 
            // checkBoxReadOnly
            // 
            this.checkBoxReadOnly.AutoSize = true;
            this.checkBoxReadOnly.Location = new System.Drawing.Point(94, 19);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(100, 24);
            this.checkBoxReadOnly.TabIndex = 17;
            this.checkBoxReadOnly.Text = "Read-only";
            this.checkBoxReadOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxHidden
            // 
            this.checkBoxHidden.AutoSize = true;
            this.checkBoxHidden.Location = new System.Drawing.Point(200, 19);
            this.checkBoxHidden.Name = "checkBoxHidden";
            this.checkBoxHidden.Size = new System.Drawing.Size(79, 24);
            this.checkBoxHidden.TabIndex = 17;
            this.checkBoxHidden.Text = "Hidden";
            this.checkBoxHidden.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApply.Location = new System.Drawing.Point(251, 291);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(82, 32);
            this.buttonApply.TabIndex = 17;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // FolderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 331);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBoxAttributes);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxContains);
            this.Controls.Add(this.textBoxCreated);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelCreated);
            this.Controls.Add(this.labelContains);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 370);
            this.Name = "FolderInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.groupBoxAttributes.ResumeLayout(false);
            this.groupBoxAttributes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelContains;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxCreated;
        private System.Windows.Forms.TextBox textBoxContains;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.GroupBox groupBoxAttributes;
        private System.Windows.Forms.CheckBox checkBoxHidden;
        private System.Windows.Forms.CheckBox checkBoxReadOnly;
        private System.Windows.Forms.Button buttonApply;
    }
}