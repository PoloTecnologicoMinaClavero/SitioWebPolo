using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PoloSitioWeb.Configs
{

    public class EmailConfig
    {
        public string FromName { get; set; }
        public string FromAddress { get; set; }
        public string FromPassword { get; set; }

        public string Smtp { get; set; }

        public int Port { get; set; }

        public string ToAddress { get; set; }
        public bool EnableSsl { get; set; }


        public SmtpClient SmtpClient => GetSmtpClient();
        public MailMessage MailMessage => GetMailMessage();

        private MailMessage GetMailMessage()
        {
            return new MailMessage(FromAddress, ToAddress);
        }
        private SmtpClient GetSmtpClient()
        {
            //smtp configuracion
            var smtpServer = new SmtpClient(Smtp);
            smtpServer.Port = Port;
            smtpServer.UseDefaultCredentials = false;
            smtpServer.Credentials = new System.Net.NetworkCredential(FromAddress, FromPassword);
            smtpServer.EnableSsl = EnableSsl;
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;

            return smtpServer;
        }


    }

}
