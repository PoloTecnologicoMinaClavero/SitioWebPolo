using Microsoft.AspNetCore.Mvc;
using PoloSitioWeb.Controllers.Request;
using PoloSitioWeb.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PoloSitioWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactoApiController : ControllerBase
    {
        private readonly IEmailService _service;

        public ContactoApiController(IEmailService service)
        {
            _service = service;
        }

        [HttpPost("/api/Contacto/SendMail")]
        public void SendMail([FromBody]ContactoRequest contacto)
        {
            _service.SendMail(contacto.GetValues());
        }

        [HttpPost("/api/Contacto/SendMailAsync")]
        public Task SendMailAsync([FromBody] ContactoRequest contacto)
        {
          return _service.SendMailAsync(contacto.GetValues());
        }

    }
}
