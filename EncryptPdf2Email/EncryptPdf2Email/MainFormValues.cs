using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptPdf2Email
{
    class MainFormValues
    {
        public string ExistingPassword { get; set; }
        public string Password { get; set; }
        public string TargetPath { get; set; }
        public string SaveAsPath { get; set; }

        public MainFormValues(string existingPassword, string password, string targetPath, string saveAsPath)
        {
            ExistingPassword = existingPassword;
            Password = password;
            TargetPath = targetPath;
            SaveAsPath = saveAsPath;
        }
    }
}
