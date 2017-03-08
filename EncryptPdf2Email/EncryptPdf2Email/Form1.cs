﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EncryptPdf2Email
{
    public partial class MainForm : Form
    {
        public static BindingList<FileData> fileData = new BindingList<FileData>();
        public static bool proceedFromDirectorForm;
        public static List<DirectorData> directorData = new List<DirectorData>();
        public static List<string> emailData = new List<string>();

        //Form checkbox values
        public static bool Encrypt;
        public static bool Email;
        public static bool GroupBy;
        public static bool SaveCopy;
        public static bool Overwrite;
        public static bool Outlook = true;

        //system values
        public static string tempFolder;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempFolder = Path.GetTempPath();

            DataGrid.DataSource = fileData;
        }

        private void chk_showNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showNewPassword.Checked)
            {
                string a = txt_password.Text;
                txt_password.UseSystemPasswordChar = false;
                txt_password.Text = a;
            } else
            {
                string a = txt_password.Text;
                txt_password.UseSystemPasswordChar = true;
                txt_password.Text = a;
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            fileData.Clear();

            DirectorForm.filePath = txt_directorsFilePath.Text;

            DirectorForm form = new DirectorForm();

            form.ShowDialog();

            if (txt_targetFolder.Text.EndsWith(@"\"))
            {
                LoadFiles(txt_targetFolder.Text);
            } else
            {
                LoadFiles(txt_targetFolder.Text + @"\");
            }
            
        }

        private void LoadFiles(string targetFolder)
        {
            string site;
            string fullName;
            string fileName;

            try
            {
                foreach (string file in Directory.GetFiles(targetFolder, "*" + txt_delimiter.Text + "*" + ".pdf"))
                {
                    FileInfo fi = new FileInfo(file);

                    site = fi.Name.Substring(0, 3);
                    fullName = fi.FullName;
                    fileName = fi.Name;

                    foreach (DirectorData item in directorData)
                    {
                        if (item.Site == site)
                        {
                            FileData fd = new FileData(fullName, fileName, item.Email, site);
                            fileData.Add(fd);
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_loadEmailData_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_directorsFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btn_loadOutputFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_outputFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void btn_folderDialog_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_targetFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void chk_showExistingPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showExistingPassword.Checked)
            {
                string a = txt_existingPassword.Text;
                txt_existingPassword.UseSystemPasswordChar = false;
                txt_existingPassword.Text = a;
            }
            else
            {
                string a = txt_existingPassword.Text;
                txt_existingPassword.UseSystemPasswordChar = true;
                txt_existingPassword.Text = a;
            }
        }

        private void chk_encrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_encrypt.Checked)
            {
                AddNewFileName();

                txt_existingPassword.Enabled = true;
                txt_password.Enabled = true;
                Encrypt = true;
            } else
            {
                AddNewFileName(1);

                txt_existingPassword.Enabled = false;
                txt_password.Enabled = false;
                Encrypt = false;
            }
        }

        private void chk_saveCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_saveCopy.Checked)
            {
                txt_outputFolderPath.Enabled = true;
                btn_loadOutputFolder.Enabled = true;
                SaveCopy = true;
            } else
            {
                txt_outputFolderPath.Enabled = false;
                btn_loadOutputFolder.Enabled = false;
                SaveCopy = false;
            }
        }

        private void btn_removeItems_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGrid.SelectedRows)
            {
                DataGrid.Rows.Remove(row);
            }
        }

        private void chk_email_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_email.Checked)
            {
                EmailForm ef = new EmailForm();
                ef.ShowDialog();

                chk_groupby.Enabled = true;

                Email = true;
            } else
            {
                chk_groupby.Checked = false;
                chk_groupby.Enabled = false;
                Email = false;
            }
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            MainFormValues mfv = new MainFormValues(txt_existingPassword.Text, txt_password.Text, txt_targetFolder.Text, txt_outputFolderPath.Text);

            if (mfv.TargetPath == mfv.SaveAsPath)
            {
                MessageBox.Show("You are attempting to overwrite the original files.",
                    "Error Executing Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            progressBar1.Maximum = fileData.Count;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            backgroundWorker1.RunWorkerAsync(mfv);
            btn_execute.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MainFormValues mfv = (MainFormValues)e.Argument;

            PdfTools pt = new PdfTools();

            string outputLocation;
            string outputFinal;
            string tempFinal;
            int count = 0;

            if (MainForm.SaveCopy)
            {
                if (Directory.Exists(mfv.SaveAsPath))
                {
                    if (!mfv.SaveAsPath.EndsWith(@"\"))
                    {
                        mfv.SaveAsPath = mfv.SaveAsPath + @"\";
                    }
                    outputLocation = mfv.SaveAsPath;
                } else
                {
                    MessageBox.Show("Output Folder does not exist.", "Error Executing Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                
            } else
            {
                outputLocation = tempFolder;
            }

            foreach (FileData fd in fileData)
            {
                count += 1;               
                outputFinal = outputLocation + fd.FileName;
                tempFinal = tempFolder + fd.FileName;

                if (Encrypt)
                {
                    if (pt.IsEncrypted(fd.FullFileName))
                    {
                        string newFile = pt.DecryptPdf(fd.FullFileName, tempFinal, mfv.ExistingPassword);

                        pt.EncryptPdf(newFile, outputFinal, mfv.Password, fd.Email);

                    } else
                    {
                        pt.EncryptPdf(fd.FullFileName, outputFinal, mfv.Password, fd.Email);
                    }
                }

                if (Email)
                {
                    if (GroupBy)
                    {
                        if (count <= 1)
                        {
                            if (!Encrypt)
                            {
                                emailData.Add(fd.FullFileName);

                                if (count < fileData.Count)
                                {
                                    if (fd.Site == fileData[count].Site)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        EmailTools et = new EmailTools(fd.Email, emailData);

                                        if (Outlook)
                                        {
                                            et.SendEmailOutlook();
                                        }
                                        else
                                        {
                                            et.SendEmailExchange();
                                        }

                                        emailData.Clear();
                                    }
                                }
                                else
                                {
                                    EmailTools et = new EmailTools(fd.Email, emailData);

                                    if (Outlook)
                                    {
                                        et.SendEmailOutlook();
                                    }
                                    else
                                    {
                                        et.SendEmailExchange();
                                    }

                                    emailData.Clear();
                                }
                                
                            }
                            else
                            {
                                outputFinal = outputLocation + fd.FileName;
                                emailData.Add(outputFinal);

                                if (count < fileData.Count)
                                {
                                    if (fd.Site == fileData[count].Site)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        EmailTools et = new EmailTools(fd.Email, emailData);

                                        if (Outlook)
                                        {
                                            et.SendEmailOutlook();
                                        }
                                        else
                                        {
                                            et.SendEmailExchange();
                                        }

                                        emailData.Clear();
                                    }
                                }
                                else
                                {
                                    EmailTools et = new EmailTools(fd.Email, emailData);

                                    if (Outlook)
                                    {
                                        et.SendEmailOutlook();
                                    }
                                    else
                                    {
                                        et.SendEmailExchange();
                                    }

                                    emailData.Clear();
                                }
                            }
                        }
                        else if (count > 1)
                        {
                            if (!Encrypt)
                            {
                                emailData.Add(fd.FullFileName);

                                if (count < fileData.Count)
                                {
                                    if (fd.Site == fileData[count].Site)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        EmailTools et = new EmailTools(fd.Email, emailData);

                                        if (Outlook)
                                        {
                                            et.SendEmailOutlook();
                                        }
                                        else
                                        {
                                            et.SendEmailExchange();
                                        }

                                        emailData.Clear();
                                    }
                                }
                                else
                                {
                                    EmailTools et = new EmailTools(fd.Email, emailData);

                                    if (Outlook)
                                    {
                                        et.SendEmailOutlook();
                                    }
                                    else
                                    {
                                        et.SendEmailExchange();
                                    }

                                    emailData.Clear();
                                }

                            }
                            else
                            {
                                outputFinal = outputLocation + fd.FileName;
                                emailData.Add(outputFinal);

                                if (count < fileData.Count)
                                {
                                    if (fd.Site == fileData[count].Site)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        EmailTools et = new EmailTools(fd.Email, emailData);

                                        if (Outlook)
                                        {
                                            et.SendEmailOutlook();
                                        }
                                        else
                                        {
                                            et.SendEmailExchange();
                                        }

                                        emailData.Clear();
                                    }
                                }
                                else
                                {
                                    EmailTools et = new EmailTools(fd.Email, emailData);

                                    if (Outlook)
                                    {
                                        et.SendEmailOutlook();
                                    }
                                    else
                                    {
                                        et.SendEmailExchange();
                                    }

                                    emailData.Clear();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!Encrypt)
                        {
                            emailData.Add(fd.FullFileName);
                        }
                        else
                        {
                            outputFinal = outputLocation + fd.FileName;
                            emailData.Add(outputFinal);
                        }
                        EmailTools et = new EmailTools(fd.Email, emailData);

                        if (Outlook)
                        {
                            et.SendEmailOutlook();
                        }
                        else
                        {
                            et.SendEmailExchange();
                        }
                    }                    
                                                         
                }             
                backgroundWorker1.ReportProgress(0);
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {           
            progressBar1.PerformStep();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_execute.Enabled = true;
        }

        private void exchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Outlook = false;
            exchangeToolStripMenuItem.BackColor = Color.Coral;
            outlookToolStripMenuItem.BackColor = SystemColors.Menu;
        }

        private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Outlook = true;
            outlookToolStripMenuItem.BackColor = Color.Coral;
            exchangeToolStripMenuItem.BackColor = SystemColors.Menu;
        }

        private void chk_groupby_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_groupby.Checked)
            {
                GroupBy = true;
            } else
            {
                GroupBy = false;
            }
        }

        private static void AddNewFileName()
        {
            foreach (FileData fd in fileData)
            {
                int lngth = fd.FileName.Length;
                fd.NewFileName = fd.FileName.Substring(0, lngth - 4) + @"_encrypted.pdf";
            }
        }
        private static void AddNewFileName(int one)
        {
            foreach (FileData fd in fileData)
            {
                int lngth = fd.FileName.Length;
                fd.NewFileName = fd.FileName.Substring(0, lngth - 14) + @".pdf";
            }
        }
    }
}
