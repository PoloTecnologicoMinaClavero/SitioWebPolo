using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloSitioWeb.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendMailAsync(IEnumerable<string> parametros);
        void SendMail(IEnumerable<string> parametros);
    }
}
