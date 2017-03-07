using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptPdf2Email
{
    public class FileData : INotifyPropertyChanged
    {
        private string _fileName;
        private string _fullfileName;
        private string _newfileName;
        private string _email;
        private string _site;

        public event PropertyChangedEventHandler PropertyChanged;

        public FileData (string fullFileName, string fileName, string email, string site)
        {
            _fullfileName = fullFileName;
            _fileName = fileName;
            _email = email;
            _site = site;
        }

        [Browsable(false)]
        public string FullFileName
        {
            get { return _fullfileName; }
            set
            {
                _fullfileName = value;
                this.NotifyPropertyChanged("FullFileName");
            }
        }
        [Browsable(false)]
        public string NewFileName
        {
            get { return _newfileName; }
            set
            {
                _newfileName = value;
                this.NotifyPropertyChanged("NewFileName");
            }
        }
        [ReadOnly(true)]
        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                this.NotifyPropertyChanged("FileName");
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                this.NotifyPropertyChanged("Email");
            }
        }
        [Browsable(false)]
        public string Site
        {
            get { return _site; }
            set
            {
                _site = value;
                this.NotifyPropertyChanged("Site");
            }
        }

        private void NotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }
}
