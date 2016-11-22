using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.exceptions;

namespace EncryptPdf2Email
{
    class PdfTools
    {       
        public void EncryptPdf(string inputFile, string outputFile, string password, string email)
        {
            try
            {
                using (Stream input = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (Stream output = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        PdfReader reader = new PdfReader(input);
                        PdfEncryptor.Encrypt(reader, output, PdfWriter.ENCRYPTION_AES_256, password, password, PdfWriter.ENCRYPTION_AES_256);
                    }
                }                             
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("Error Message: " + ex.Message + Environment.NewLine + "Inner Exception: "
                    + ex.InnerException + Environment.NewLine + "Stack Trace: " + ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message + Environment.NewLine + "Inner Exception: "
                    + ex.InnerException + Environment.NewLine + "Stack Trace: " + ex.StackTrace);

                File.Delete(outputFile);
            }
        }

        public string DecryptPdf(string input, string output, string password)
        {        
            try
            {
                PdfReader reader = new PdfReader(input, new ASCIIEncoding().GetBytes(password));

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    PdfStamper stamper = new PdfStamper(reader, memoryStream);
                    stamper.Close();
                    reader.Close();
                    System.IO.File.WriteAllBytes(output, memoryStream.ToArray());
                }
                return output;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return output;
            }
        }
    

        public bool IsEncrypted(string file)
        {
            try
            {
                PdfReader reader = new PdfReader(file);
                reader.Close();
                return false;
            } catch(BadPasswordException)
            {
                return true;
            }
        }
    }
}
