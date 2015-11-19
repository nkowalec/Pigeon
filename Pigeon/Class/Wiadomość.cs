using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Pigeon.Class;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Pigeon
{
    public partial class Wiadomość
    {
        /// <summary>
        /// Wysyła wiadomość wg danych
        /// </summary>
        public void Wyslij()
        {
            MailMessage wiadomosc = new MailMessage();
            
            wiadomosc.To.Add(this.Adresat.Wartość);
            wiadomosc.IsBodyHtml = true;
            
            foreach(AdresatDW adrDW in this.AdresaciDW)
            {
                wiadomosc.Bcc.Add(adrDW.Kontakt.Wartość);
            }

            wiadomosc.Subject = this.Temat;

            wiadomosc.Body = this.Treść;
            Config conf = Config.GetInstance();
            wiadomosc.From = new MailAddress(conf.Email);
            
            foreach(Pigeon.Załącznik zal in this.Załączniki)
            {
                wiadomosc.Attachments.Add(new Attachment(new MemoryStream(zal.Dane), zal.Nazwa));
            }

            SmtpClient smtp = new SmtpClient(conf.SMTP_Adres, conf.SMTP_Port);
            smtp.Credentials = new NetworkCredential(conf.Login, conf.Pass);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtp.Send(wiadomosc);
            }
            catch(Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }
    }
}
