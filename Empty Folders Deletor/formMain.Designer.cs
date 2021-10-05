namespace Empty_Folders_Deletor
{
    partial class formMain
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
            this.buttonCheckEmptyFolders = new CustomUI.Controls.CustomButton();
            this.buttonProcessEmptyFolders = new CustomUI.Controls.CustomButton();
            this.textBoxPath = new CustomUI.Controls.CustomTextBox();
            this.textBoxLog = new CustomUI.Controls.CustomTextBox();
            this.buttonCheckEmptyFiles = new CustomUI.Controls.CustomButton();
            this.buttonProcessEmptyFiles = new CustomUI.Controls.CustomButton();
            this.customGroupBox1 = new CustomUI.Controls.CustomGroupBox();
            this.customButtonBrowse = new CustomUI.Controls.CustomButton();
            this.customLabelPath = new CustomUI.Controls.CustomLabel();
            this.folderBrowserDialogPath = new System.Windows.Forms.FolderBrowserDialog();
            this.customGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCheckEmptyFolders
            // 
            this.buttonCheckEmptyFolders.Location = new System.Drawing.Point(464, 45);
            this.buttonCheckEmptyFolders.Name = "buttonCheckEmptyFolders";
            this.buttonCheckEmptyFolders.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCheckEmptyFolders.Size = new System.Drawing.Size(134, 23);
            this.buttonCheckEmptyFolders.TabIndex = 7;
            this.buttonCheckEmptyFolders.Text = "Check Empty Folders";
            this.buttonCheckEmptyFolders.Click += new System.EventHandler(this.customButtonCheckEmptyFolders_Click);
            // 
            // buttonProcessEmptyFolders
            // 
            this.buttonProcessEmptyFolders.Location = new System.Drawing.Point(604, 45);
            this.buttonProcessEmptyFolders.Name = "buttonProcessEmptyFolders";
            this.buttonProcessEmptyFolders.Padding = new System.Windows.Forms.Padding(5);
            this.buttonProcessEmptyFolders.Size = new System.Drawing.Size(134, 23);
            this.buttonProcessEmptyFolders.TabIndex = 8;
            this.buttonProcessEmptyFolders.Text = "Process Empty Folders";
            this.buttonProcessEmptyFolders.Click += new System.EventHandler(this.customButtonProcessEmptyFolders_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxPath.Location = new System.Drawing.Point(41, 19);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(642, 20);
            this.textBoxPath.TabIndex = 3;
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxLog.Location = new System.Drawing.Point(12, 101);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(744, 511);
            this.textBoxLog.TabIndex = 9;
            // 
            // buttonCheckEmptyFiles
            // 
            this.buttonCheckEmptyFiles.Location = new System.Drawing.Point(41, 45);
            this.buttonCheckEmptyFiles.Name = "buttonCheckEmptyFiles";
            this.buttonCheckEmptyFiles.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCheckEmptyFiles.Size = new System.Drawing.Size(134, 23);
            this.buttonCheckEmptyFiles.TabIndex = 5;
            this.buttonCheckEmptyFiles.Text = "Check Empty Files";
            this.buttonCheckEmptyFiles.Click += new System.EventHandler(this.customButtonCheckEmptyFiles_Click);
            // 
            // buttonProcessEmptyFiles
            // 
            this.buttonProcessEmptyFiles.Location = new System.Drawing.Point(181, 45);
            this.buttonProcessEmptyFiles.Name = "buttonProcessEmptyFiles";
            this.buttonProcessEmptyFiles.Padding = new System.Windows.Forms.Padding(5);
            this.buttonProcessEmptyFiles.Size = new System.Drawing.Size(134, 23);
            this.buttonProcessEmptyFiles.TabIndex = 6;
            this.buttonProcessEmptyFiles.Text = "Process Empty Files";
            this.buttonProcessEmptyFiles.Click += new System.EventHandler(this.customButtonProcessEmptyFiles_Click);
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.customGroupBox1.Controls.Add(this.customButtonBrowse);
            this.customGroupBox1.Controls.Add(this.customLabelPath);
            this.customGroupBox1.Controls.Add(this.textBoxPath);
            this.customGroupBox1.Controls.Add(this.buttonProcessEmptyFiles);
            this.customGroupBox1.Controls.Add(this.buttonCheckEmptyFolders);
            this.customGroupBox1.Controls.Add(this.buttonCheckEmptyFiles);
            this.customGroupBox1.Controls.Add(this.buttonProcessEmptyFolders);
            this.customGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Size = new System.Drawing.Size(744, 83);
            this.customGroupBox1.TabIndex = 1;
            this.customGroupBox1.TabStop = false;
            // 
            // customButtonBrowse
            // 
            this.customButtonBrowse.Location = new System.Drawing.Point(689, 19);
            this.customButtonBrowse.Name = "customButtonBrowse";
            this.customButtonBrowse.Padding = new System.Windows.Forms.Padding(5);
            this.customButtonBrowse.Size = new System.Drawing.Size(49, 20);
            this.customButtonBrowse.TabIndex = 4;
            this.customButtonBrowse.Text = "...";
            this.customButtonBrowse.Click += new System.EventHandler(this.customButtonBrowse_Click);
            // 
            // customLabelPath
            // 
            this.customLabelPath.AutoSize = true;
            this.customLabelPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.customLabelPath.Location = new System.Drawing.Point(6, 21);
            this.customLabelPath.Name = "customLabelPath";
            this.customLabelPath.Size = new System.Drawing.Size(29, 13);
            this.customLabelPath.TabIndex = 2;
            this.customLabelPath.Text = "Path";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 624);
            this.Controls.Add(this.customGroupBox1);
            this.Controls.Add(this.textBoxLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "Empty Folders Deleter";
            this.customGroupBox1.ResumeLayout(false);
            this.customGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomUI.Controls.CustomButton buttonCheckEmptyFolders;
        private CustomUI.Controls.CustomButton buttonProcessEmptyFolders;
        private CustomUI.Controls.CustomTextBox textBoxPath;
        private CustomUI.Controls.CustomTextBox textBoxLog;
        private CustomUI.Controls.CustomButton buttonCheckEmptyFiles;
        private CustomUI.Controls.CustomButton buttonProcessEmptyFiles;
        private CustomUI.Controls.CustomGroupBox customGroupBox1;
        private CustomUI.Controls.CustomLabel customLabelPath;
        private CustomUI.Controls.CustomButton customButtonBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPath;
    }
}

