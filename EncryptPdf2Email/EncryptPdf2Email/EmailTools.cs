using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace EncryptPdf2Email
{
    class EmailTools
    {
        public string Recipients { get; set; }
        public string Attachment { get; set; }
        public static string Subject { get; set; }
        public static string Body { get; set; }

        public EmailTools(string recipients, string attachment)
        {
            Recipients = recipients;
            Attachment = attachment;
        }

        public void SendEmailOutlook()
        {
            Outlook.Application app = new Outlook.Application();
            Outlook.MailItem mailItem = app.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Recipients.Add(Recipients);
            mailItem.Attachments.Add(Attachment);
            mailItem.Subject = Subject;
            mailItem.Body = Body;
            mailItem.Send();
        }

        public void SendEmailExchange()
        {
            
        }
    }

}
