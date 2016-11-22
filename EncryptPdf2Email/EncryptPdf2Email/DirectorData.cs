using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptPdf2Email
{
    public class DirectorData : INotifyPropertyChanged
    {
        private string _site;
        private string _email;

        public event PropertyChangedEventHandler PropertyChanged;

        public DirectorData(string site, string email)
        {
            _site = site;
            _email = email;
        }

        public string Site
        {
            get { return _site; }
            set
            {
                _site = value;
                this.NotifyPropertyChanged("Site");
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
        private void NotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }
}
