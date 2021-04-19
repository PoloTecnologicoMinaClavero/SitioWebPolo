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

            if (string.IsNullOrWhiteSpace(_emailConfig.FromPassword))
            {
                _emailConfig.FromPassword = Environment.GetEnvironmentVariable("POLOMC_FROMEMAILPASSWORD");
            }
        }

        public void SendMail(IEnumerable<string> parametros)
        {
            _emailConfig.SmtpClient.Send(GetMailMessage(parametros));
        }

        public async Task SendMailAsync(IEnumerable<string> parametros)
        {
            try
            {
                await _emailConfig.SmtpClient.SendMailAsync(GetMailMessage(parametros));
            }
            catch (Exception ex)
            {
                throw new Exception(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") + " ||| " + _emailConfig.FromPassword + " ||| " + ex.Message);
            }

        }

        private MailMessage GetMailMessage(IEnumerable<string> parametros)
        {
            var arrParametros = parametros.ToArray();

            if (arrParametros.Length < 4)
                throw new Exception("se esperaban 4 parametros");

            var email = arrParametros[1];

            var mailMessage = _emailConfig.MailMessage;
            mailMessage.From = new MailAddress(email);
            mailMessage.Subject = "Consulta página web Polo Tecnológico";
            mailMessage.ReplyToList.Add(mailMessage.From);
            mailMessage.IsBodyHtml = true;

            mailMessage.Body = @$"<p><strong>Nombre y Apellido</strong>: {arrParametros[0]}. </p>
                                  <p><strong>Email</strong>: {arrParametros[1]}.</p>
                                  <p><strong>Asunto</strong>: {arrParametros[2]}.</p>
                                  <p><strong>Mensaje</strong>: {arrParametros[3]}.</p>";
            return mailMessage;
        }
    }
}
