using Microsoft.Extensions.Options;
using PoloSitioWeb.Configs;
using PoloSitioWeb.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PoloSitioWeb.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailConfig _emailConfig;

        public EmailService(IOptions<EmailConfig> emailConfig)
        {
            _emailConfig = emailConfig.Value;
        }

        public void SendMail(IEnumerable<string> parametros)
        {
            _emailConfig.SmtpClient.Send(GetMailMessage(parametros));
        }

        public async Task SendMailAsync(IEnumerable<string> parametros)
        {
            await _emailConfig.SmtpClient.SendMailAsync(GetMailMessage(parametros));
        }

        private MailMessage GetMailMessage(IEnumerable<string> parametros)
        {
            var arrParametros = parametros.ToArray();

            if (arrParametros.Length < 4)
                throw new Exception("se esperaban 4 parametros");

            var mailMessage = _emailConfig.MailMessage;
            mailMessage.Subject = "Consulta página web Polo Tecnológico";

            mailMessage.IsBodyHtml = true;

            mailMessage.Body = @$"<strong>Nombre y Apellido</strong>: {arrParametros[0]}.
                                  <strong>Email</strong>: {arrParametros[1]}.
                                  <strong>Asunto</strong>: {arrParametros[2]}.
                                  <strong>Mensaje</strong>: {arrParametros[3]}.";
            return mailMessage;
        }
    }
}
