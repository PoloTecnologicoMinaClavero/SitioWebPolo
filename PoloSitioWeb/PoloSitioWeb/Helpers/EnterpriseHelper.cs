using PoloSitioWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloSitioWeb.Helpers
{
    public static class EnterpriseHelper
    {
        public static List<Enterprise> GetAll()
        {
            var enterprises = new List<Enterprise>();

            enterprises.Add(new Enterprise()
            {
                Name = "IncluIT",
                SiteUrl = "https://incluit.com",
                ImageUrl = "/assets/img/logos/Incluit.svg",
                ImageDescription = "IncluIT Logo",
                Description = "\"IncluIT es una empresa de TI de larga data y madura , donde nuestro pasado habla por sí mismo , nuestro presente es aún mejor y nuestro futuro será alucinante. Desde 1994, ha consolidado una firma global de servicios de consultoría tecnológica de alto nivel en un sofisticado destino nearshore para Fintech, Telco Cable and Media, Transporte Inteligente y Salud, y programas de capacitación.\""
            });
            enterprises.Add(new Enterprise()
            {
                Name = "Verne",
                SiteUrl = "https://www.vernegroup.com/",
                ImageUrl = "/assets/img/logos/Verne.png",
                ImageDescription = "Verne Logo",
                Description = "\"Con más de 40 años de experiencia, Verne Technology Group cuenta con dos divisiones de negocio, Verne TELCO y Verne TECH, que abarcan los sectores de telecomunicaciones y TIC, respectivamente. Un proyecto que, emulando a Julio Verne, nace con el propósito de seguir siendo visionarios de la transformación tecnológica y la digitalización de nuestro entorno.\"",
            });
            enterprises.Add(new Enterprise()
            {
                Name = "Mantis",
                SiteUrl = "http://www.mantis.com.ar/",
                ImageUrl = "/assets/img/logos/Mantis-Azul.png",
                ImageDescription = "Mantis Logo",
                Description= "\"Somos una Empresa que ha desarrollado un Software que resuelve todas las necesidades Administrativas, Impositivas y de Gestión que requiere su Empresa. Mantis es más que un software, es además, un servicio integral que se adapta a las necesidades de su empresa focalizándonos en: capacitación, asesoramiento, personalización, puesta en marcha y atención post venta.\""
            });


            return enterprises;
        }
    }
}
