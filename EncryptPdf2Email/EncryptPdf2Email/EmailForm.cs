using System;
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
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void btn_EmailFormFinished_Click(object sender, EventArgs e)
        {
            EmailTools.Subject = txt_SubjectEmail.Text;
            
            EmailTools.Body = rtxt_BodyEmail.Text;

            this.Close();
        }
    }
}
