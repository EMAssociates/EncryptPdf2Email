namespace EncryptPdf2Email
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_targetFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_folderDialog = new System.Windows.Forms.Button();
            this.btn_removeItems = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.chk_showNewPassword = new System.Windows.Forms.CheckBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.txt_delimiter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.txt_directorsFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_loadEmailData = new System.Windows.Forms.Button();
            this.txt_outputFolderPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_loadOutputFolder = new System.Windows.Forms.Button();
            this.chk_encrypt = new System.Windows.Forms.CheckBox();
            this.txt_existingPassword = new System.Windows.Forms.TextBox();
            this.lbl_existingPassword = new System.Windows.Forms.Label();
            this.chk_showExistingPassword = new System.Windows.Forms.CheckBox();
            this.chk_email = new System.Windows.Forms.CheckBox();
            this.chk_saveCopy = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outlookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chk_groupby = new System.Windows.Forms.CheckBox();
            this.txt_charPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_targetFolder
            // 
            this.txt_targetFolder.Location = new System.Drawing.Point(28, 42);
            this.txt_targetFolder.Name = "txt_targetFolder";
            this.txt_targetFolder.Size = new System.Drawing.Size(529, 20);
            this.txt_targetFolder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target Folder Path:";
            // 
            // btn_folderDialog
            // 
            this.btn_folderDialog.Location = new System.Drawing.Point(559, 42);
            this.btn_folderDialog.Name = "btn_folderDialog";
            this.btn_folderDialog.Size = new System.Drawing.Size(31, 20);
            this.btn_folderDialog.TabIndex = 2;
            this.btn_folderDialog.Text = "...";
            this.btn_folderDialog.UseVisualStyleBackColor = true;
            this.btn_folderDialog.Click += new System.EventHandler(this.btn_folderDialog_Click);
            // 
            // btn_removeItems
            // 
            this.btn_removeItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeItems.Location = new System.Drawing.Point(405, 438);
            this.btn_removeItems.Name = "btn_removeItems";
            this.btn_removeItems.Size = new System.Drawing.Size(185, 40);
            this.btn_removeItems.TabIndex = 4;
            this.btn_removeItems.Text = "Remove Selected Items";
            this.btn_removeItems.UseVisualStyleBackColor = true;
            this.btn_removeItems.Click += new System.EventHandler(this.btn_removeItems_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password:";
            // 
            // txt_password
            // 
            this.txt_password.Enabled = false;
            this.txt_password.Location = new System.Drawing.Point(323, 532);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(182, 20);
            this.txt_password.TabIndex = 6;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // chk_showNewPassword
            // 
            this.chk_showNewPassword.AutoSize = true;
            this.chk_showNewPassword.Location = new System.Drawing.Point(508, 535);
            this.chk_showNewPassword.Name = "chk_showNewPassword";
            this.chk_showNewPassword.Size = new System.Drawing.Size(83, 17);
            this.chk_showNewPassword.TabIndex = 8;
            this.chk_showNewPassword.Text = "Show Text?";
            this.chk_showNewPassword.UseVisualStyleBackColor = true;
            this.chk_showNewPassword.CheckedChanged += new System.EventHandler(this.chk_showNewPassword_CheckedChanged);
            // 
            // btn_execute
            // 
            this.btn_execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_execute.Location = new System.Drawing.Point(404, 637);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(185, 46);
            this.btn_execute.TabIndex = 9;
            this.btn_execute.Text = "Start";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(25, 179);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(565, 253);
            this.DataGrid.TabIndex = 10;
            // 
            // txt_delimiter
            // 
            this.txt_delimiter.Location = new System.Drawing.Point(28, 144);
            this.txt_delimiter.Name = "txt_delimiter";
            this.txt_delimiter.Size = new System.Drawing.Size(172, 20);
            this.txt_delimiter.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Text Delimiter (optional):";
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(404, 133);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(185, 40);
            this.btn_load.TabIndex = 13;
            this.btn_load.Text = "Load Files";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txt_directorsFilePath
            // 
            this.txt_directorsFilePath.AccessibleName = "dfp";
            this.txt_directorsFilePath.Location = new System.Drawing.Point(28, 93);
            this.txt_directorsFilePath.Name = "txt_directorsFilePath";
            this.txt_directorsFilePath.Size = new System.Drawing.Size(529, 20);
            this.txt_directorsFilePath.TabIndex = 14;
            this.txt_directorsFilePath.Text = "\\\\grover\\Surveys\\PDF Merge Output\\Directors.txt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Load Email Addresses From File:";
            // 
            // btn_loadEmailData
            // 
            this.btn_loadEmailData.Location = new System.Drawing.Point(559, 93);
            this.btn_loadEmailData.Name = "btn_loadEmailData";
            this.btn_loadEmailData.Size = new System.Drawing.Size(31, 20);
            this.btn_loadEmailData.TabIndex = 16;
            this.btn_loadEmailData.Text = "...";
            this.btn_loadEmailData.UseVisualStyleBackColor = true;
            this.btn_loadEmailData.Click += new System.EventHandler(this.btn_loadEmailData_Click);
            // 
            // txt_outputFolderPath
            // 
            this.txt_outputFolderPath.Enabled = false;
            this.txt_outputFolderPath.Location = new System.Drawing.Point(28, 595);
            this.txt_outputFolderPath.Name = "txt_outputFolderPath";
            this.txt_outputFolderPath.Size = new System.Drawing.Size(529, 20);
            this.txt_outputFolderPath.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Output Folder Path (optional):";
            // 
            // btn_loadOutputFolder
            // 
            this.btn_loadOutputFolder.Enabled = false;
            this.btn_loadOutputFolder.Location = new System.Drawing.Point(559, 595);
            this.btn_loadOutputFolder.Name = "btn_loadOutputFolder";
            this.btn_loadOutputFolder.Size = new System.Drawing.Size(31, 20);
            this.btn_loadOutputFolder.TabIndex = 19;
            this.btn_loadOutputFolder.Text = "...";
            this.btn_loadOutputFolder.UseVisualStyleBackColor = true;
            this.btn_loadOutputFolder.Click += new System.EventHandler(this.btn_loadOutputFolder_Click);
            // 
            // chk_encrypt
            // 
            this.chk_encrypt.AutoSize = true;
            this.chk_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_encrypt.Location = new System.Drawing.Point(25, 451);
            this.chk_encrypt.Name = "chk_encrypt";
            this.chk_encrypt.Size = new System.Drawing.Size(69, 17);
            this.chk_encrypt.TabIndex = 20;
            this.chk_encrypt.Text = "Encrypt";
            this.chk_encrypt.UseVisualStyleBackColor = true;
            this.chk_encrypt.CheckedChanged += new System.EventHandler(this.chk_encrypt_CheckedChanged);
            // 
            // txt_existingPassword
            // 
            this.txt_existingPassword.Enabled = false;
            this.txt_existingPassword.Location = new System.Drawing.Point(30, 531);
            this.txt_existingPassword.Name = "txt_existingPassword";
            this.txt_existingPassword.Size = new System.Drawing.Size(182, 20);
            this.txt_existingPassword.TabIndex = 21;
            this.txt_existingPassword.UseSystemPasswordChar = true;
            // 
            // lbl_existingPassword
            // 
            this.lbl_existingPassword.AutoSize = true;
            this.lbl_existingPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_existingPassword.Location = new System.Drawing.Point(27, 512);
            this.lbl_existingPassword.Name = "lbl_existingPassword";
            this.lbl_existingPassword.Size = new System.Drawing.Size(208, 16);
            this.lbl_existingPassword.TabIndex = 22;
            this.lbl_existingPassword.Text = "Existing Password (optional):";
            // 
            // chk_showExistingPassword
            // 
            this.chk_showExistingPassword.AutoSize = true;
            this.chk_showExistingPassword.Location = new System.Drawing.Point(215, 534);
            this.chk_showExistingPassword.Name = "chk_showExistingPassword";
            this.chk_showExistingPassword.Size = new System.Drawing.Size(83, 17);
            this.chk_showExistingPassword.TabIndex = 23;
            this.chk_showExistingPassword.Text = "Show Text?";
            this.chk_showExistingPassword.UseVisualStyleBackColor = true;
            this.chk_showExistingPassword.CheckedChanged += new System.EventHandler(this.chk_showExistingPassword_CheckedChanged);
            // 
            // chk_email
            // 
            this.chk_email.AutoSize = true;
            this.chk_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_email.Location = new System.Drawing.Point(189, 451);
            this.chk_email.Name = "chk_email";
            this.chk_email.Size = new System.Drawing.Size(56, 17);
            this.chk_email.TabIndex = 24;
            this.chk_email.Text = "Email";
            this.chk_email.UseVisualStyleBackColor = true;
            this.chk_email.CheckedChanged += new System.EventHandler(this.chk_email_CheckedChanged);
            // 
            // chk_saveCopy
            // 
            this.chk_saveCopy.AutoSize = true;
            this.chk_saveCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_saveCopy.Location = new System.Drawing.Point(98, 451);
            this.chk_saveCopy.Name = "chk_saveCopy";
            this.chk_saveCopy.Size = new System.Drawing.Size(87, 17);
            this.chk_saveCopy.TabIndex = 25;
            this.chk_saveCopy.Text = "Save Copy";
            this.chk_saveCopy.UseVisualStyleBackColor = true;
            this.chk_saveCopy.CheckedChanged += new System.EventHandler(this.chk_saveCopy_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 637);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(361, 46);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 27;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exchangeToolStripMenuItem,
            this.outlookToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.settingsToolStripMenuItem.Text = "Email Settings";
            // 
            // exchangeToolStripMenuItem
            // 
            this.exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            this.exchangeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exchangeToolStripMenuItem.Text = "Exchange";
            this.exchangeToolStripMenuItem.Click += new System.EventHandler(this.exchangeToolStripMenuItem_Click);
            // 
            // outlookToolStripMenuItem
            // 
            this.outlookToolStripMenuItem.BackColor = System.Drawing.Color.Coral;
            this.outlookToolStripMenuItem.Name = "outlookToolStripMenuItem";
            this.outlookToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.outlookToolStripMenuItem.Text = "Outlook";
            this.outlookToolStripMenuItem.Click += new System.EventHandler(this.outlookToolStripMenuItem_Click);
            // 
            // chk_groupby
            // 
            this.chk_groupby.AutoSize = true;
            this.chk_groupby.Enabled = false;
            this.chk_groupby.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_groupby.Location = new System.Drawing.Point(251, 451);
            this.chk_groupby.Name = "chk_groupby";
            this.chk_groupby.Size = new System.Drawing.Size(74, 17);
            this.chk_groupby.TabIndex = 29;
            this.chk_groupby.Text = "GroupBy";
            this.chk_groupby.UseVisualStyleBackColor = true;
            this.chk_groupby.CheckedChanged += new System.EventHandler(this.chk_groupby_CheckedChanged);
            // 
            // txt_charPosition
            // 
            this.txt_charPosition.Location = new System.Drawing.Point(206, 143);
            this.txt_charPosition.Name = "txt_charPosition";
            this.txt_charPosition.Size = new System.Drawing.Size(39, 20);
            this.txt_charPosition.TabIndex = 30;
            this.txt_charPosition.Text = "0";
            this.txt_charPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_charPosition.TextChanged += new System.EventHandler(this.txt_charPosition_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "char pos. (optional):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 695);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_charPosition);
            this.Controls.Add(this.chk_groupby);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chk_saveCopy);
            this.Controls.Add(this.chk_email);
            this.Controls.Add(this.chk_showExistingPassword);
            this.Controls.Add(this.lbl_existingPassword);
            this.Controls.Add(this.txt_existingPassword);
            this.Controls.Add(this.chk_encrypt);
            this.Controls.Add(this.btn_loadOutputFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_outputFolderPath);
            this.Controls.Add(this.btn_loadEmailData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_directorsFilePath);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_delimiter);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.chk_showNewPassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_removeItems);
            this.Controls.Add(this.btn_folderDialog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_targetFolder);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Encrypt and Email PDF Files";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txt_targetFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_folderDialog;
        private System.Windows.Forms.Button btn_removeItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.CheckBox chk_showNewPassword;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.TextBox txt_delimiter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_loadEmailData;
        private System.Windows.Forms.TextBox txt_outputFolderPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_loadOutputFolder;
        private System.Windows.Forms.CheckBox chk_encrypt;
        private System.Windows.Forms.TextBox txt_existingPassword;
        private System.Windows.Forms.Label lbl_existingPassword;
        private System.Windows.Forms.CheckBox chk_showExistingPassword;
        private System.Windows.Forms.CheckBox chk_email;
        private System.Windows.Forms.CheckBox chk_saveCopy;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txt_directorsFilePath;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exchangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outlookToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_groupby;
        private System.Windows.Forms.TextBox txt_charPosition;
        private System.Windows.Forms.Label label6;
    }
}

