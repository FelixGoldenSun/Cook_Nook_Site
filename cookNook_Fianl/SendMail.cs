using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace cookNook_Fianl
{
    public class SendMail
    {

        public bool sendMail(string recipient, string subject, string message, ArrayList AttachmentPaths)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            NetworkCredential credentials = new NetworkCredential(Globals._sender, Globals._password);
            client.EnableSsl = true;
            client.Credentials = credentials;
            try
            {
                var mail = new MailMessage(Globals._sender.Trim(), recipient.Trim());
                if (AttachmentPaths != null)
                {
                    foreach (string item in AttachmentPaths)
                    {
                        if (item.Length > 0)
                        {
                            Attachment myAttachment = new Attachment(item);
                            mail.Attachments.Add(myAttachment);
                        }
                    }
                }
                mail.Subject = subject;
                mail.Body = message;
                client.Send(mail);
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }
    }

}