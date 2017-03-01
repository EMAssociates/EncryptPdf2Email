using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptPdf2Email
{
    public partial class DirectorForm : Form
    {
        public static BindingList<DirectorData> directorData = new BindingList<DirectorData>();

        public static string filePath;


        public DirectorForm()
        {
            InitializeComponent();
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            gv_directors.DataSource = directorData;

            LoadDirectorData(filePath);
        }

        private static void LoadDirectorData(string path)
        {
            var reader = new StreamReader(File.OpenRead(path));

            while (!reader.EndOfStream)
            {
                var row = reader.ReadLine();
                var fields = row.Split(',');

                DirectorData oData = new DirectorData(fields[2],fields[3]);
         
                directorData.Add(oData);
            }
            reader.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Proceed(true);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Proceed(false);
        }

        private void DirectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            directorData.Clear();
        }

        private void Proceed(bool b)
        {
            if(b)
            {
                MainForm.proceedFromDirectorForm = true;
                MainForm.directorData = directorData.ToList<DirectorData>();
                this.Close();
            } else
            {
                MainForm.proceedFromDirectorForm = false;
                MainForm.directorData.Clear();
                directorData.Clear();
                this.Close();
            }
        }
    }
}
