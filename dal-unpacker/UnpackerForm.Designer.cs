namespace dal_unpacker
{
    partial class UnpackerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnpackerForm));
            this.fileChooser = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.chkOutputDir = new System.Windows.Forms.CheckBox();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.btnSelectOutputDir = new System.Windows.Forms.Button();
            this.outputBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpUnpack = new System.Windows.Forms.GroupBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpMessageLog = new System.Windows.Forms.GroupBox();
            this.txtMessageLog = new System.Windows.Forms.RichTextBox();
            this.grpUnpack.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpMessageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileChooser
            // 
            this.fileChooser.Filter = ".DRP Files|*.drp";
            this.fileChooser.Multiselect = true;
            this.fileChooser.Title = "Choose File(s) to Unpack";
            this.fileChooser.FileOk += new System.ComponentModel.CancelEventHandler(this.fileChooser_FileOk);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(14, 47);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(143, 46);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Choose Files";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(163, 47);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(143, 46);
            this.btnChooseFolder.TabIndex = 1;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // chkOutputDir
            // 
            this.chkOutputDir.AutoSize = true;
            this.chkOutputDir.Location = new System.Drawing.Point(15, 24);
            this.chkOutputDir.Name = "chkOutputDir";
            this.chkOutputDir.Size = new System.Drawing.Size(358, 17);
            this.chkOutputDir.TabIndex = 2;
            this.chkOutputDir.Text = "Unpack to selected directory? (same location as .drp file if unchecked)";
            this.chkOutputDir.UseVisualStyleBackColor = true;
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(15, 48);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.ReadOnly = true;
            this.txtOutputDir.Size = new System.Drawing.Size(327, 20);
            this.txtOutputDir.TabIndex = 3;
            // 
            // btnSelectOutputDir
            // 
            this.btnSelectOutputDir.Location = new System.Drawing.Point(342, 46);
            this.btnSelectOutputDir.Name = "btnSelectOutputDir";
            this.btnSelectOutputDir.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOutputDir.TabIndex = 4;
            this.btnSelectOutputDir.Text = "Browse...";
            this.btnSelectOutputDir.UseVisualStyleBackColor = true;
            this.btnSelectOutputDir.Click += new System.EventHandler(this.btnSelectOutputDir_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(330, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Click on one of these two buttons to start unpacking DAL game files.";
            // 
            // grpUnpack
            // 
            this.grpUnpack.Controls.Add(this.btnChooseFolder);
            this.grpUnpack.Controls.Add(this.btnChooseFile);
            this.grpUnpack.Controls.Add(this.lblTitle);
            this.grpUnpack.Location = new System.Drawing.Point(12, 108);
            this.grpUnpack.Name = "grpUnpack";
            this.grpUnpack.Size = new System.Drawing.Size(431, 105);
            this.grpUnpack.TabIndex = 7;
            this.grpUnpack.TabStop = false;
            this.grpUnpack.Text = "Unpack .DRP Files";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.txtOutputDir);
            this.grpOptions.Controls.Add(this.chkOutputDir);
            this.grpOptions.Controls.Add(this.btnSelectOutputDir);
            this.grpOptions.Location = new System.Drawing.Point(12, 8);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(431, 94);
            this.grpOptions.TabIndex = 8;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // grpMessageLog
            // 
            this.grpMessageLog.Controls.Add(this.txtMessageLog);
            this.grpMessageLog.Location = new System.Drawing.Point(12, 219);
            this.grpMessageLog.Name = "grpMessageLog";
            this.grpMessageLog.Size = new System.Drawing.Size(431, 325);
            this.grpMessageLog.TabIndex = 9;
            this.grpMessageLog.TabStop = false;
            this.grpMessageLog.Text = "Message Log";
            // 
            // txtMessageLog
            // 
            this.txtMessageLog.Location = new System.Drawing.Point(7, 20);
            this.txtMessageLog.Name = "txtMessageLog";
            this.txtMessageLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMessageLog.Size = new System.Drawing.Size(418, 299);
            this.txtMessageLog.TabIndex = 0;
            this.txtMessageLog.Text = "";
            // 
            // UnpackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 556);
            this.Controls.Add(this.grpMessageLog);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpUnpack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UnpackerForm";
            this.Text = "RailKill\'s Darkness and Light Unpacker";
            this.grpUnpack.ResumeLayout(false);
            this.grpUnpack.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpMessageLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileChooser;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.CheckBox chkOutputDir;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Button btnSelectOutputDir;
        private System.Windows.Forms.FolderBrowserDialog outputBrowser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpUnpack;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.GroupBox grpMessageLog;
        private System.Windows.Forms.RichTextBox txtMessageLog;
    }
}

