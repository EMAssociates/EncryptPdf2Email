using System;
using System.Collections.Generic;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Exchange.WebServices.Data;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace EncryptPdf2Email
{
    class EmailTools
    {
        public string Recipients { get; set; }
        public List<string> Attachment { get; set; }
        public static string Subject { get; set; }
        public static string Body { get; set; }

        public EmailTools(string recipients, List<string> attachment)
        {
            Recipients = recipients;
            Attachment = attachment;
        }

        public EmailTools(string recipients, string attachment)
        {
            Recipients = recipients;                
            Attachment.Add(attachment);            
        }

        public void SendEmailOutlook()
        {
            try
            {
                Outlook.Application app = new Outlook.Application();
                Outlook.MailItem mailItem = app.CreateItem(Outlook.OlItemType.olMailItem);
                mailItem.Recipients.Add(Recipients);
                mailItem.Attachments.Add(Attachment);
                mailItem.Subject = Subject;
                mailItem.Body = Body;
                mailItem.Send();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n\r\n" + ex.StackTrace, "Error Sending Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SendEmailExchange()
        {
            string userName = UserPrincipal.Current.EmailAddress;
            try
            {
                ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2010_SP2);

                service.AutodiscoverUrl(userName);

                EmailMessage message = new EmailMessage(service);

                // Set properties on the email message.
                message.Subject = Subject;
                message.Body = Body;
                message.ToRecipients.Add(Recipients);

                foreach (string item in Attachment)
                {
                    message.Attachments.AddFileAttachment(item);
                }

                // Send the email message
                message.Send();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n\r\n" + ex.StackTrace, "Error Loading Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
