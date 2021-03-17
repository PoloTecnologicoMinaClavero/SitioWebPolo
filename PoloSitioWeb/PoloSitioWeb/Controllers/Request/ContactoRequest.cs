using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PoloSitioWeb.Controllers.Request
{
   
    public class ContactoRequest 
    {
        public string NombreApellido { set; get; }
        public string Email { set; get; }
        public string Asunto { set; get; }
        public string Mensaje { set; get; }


        public IEnumerable<string> GetValues()
        {
            return new[] { NombreApellido, Email, Asunto, Mensaje };
        }

    }
}
