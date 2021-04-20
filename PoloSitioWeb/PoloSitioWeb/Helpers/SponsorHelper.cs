using PoloSitioWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloSitioWeb.Helpers
{
    public static class SponsorHelper
    {
        public static List<Sponsor> GetAll()
        {
            var sponsors = new List<Sponsor>();

            sponsors.Add(new Sponsor()
            {
                Name = "Leistung",
                SiteUrl = "https://leistungargentina.com.ar/",
                ImageUrl = "/assets/img/logos/Leistung.png",
                ImageDescription = "Leistung Logo",
                Description = "Leistung Argentina es una empresa que crea dispositivos médicos para ventilación mecánica, de muchísima importancia en estos tiempos de pandemia. Es nuestra empresa patrocinadora. Nuestros padrinos.  Han hecho una importante donación de 10 computadores para el Polo Tecnológico y 3 equipos para la Escuela Proa de Mina Clavero. Todos equipos de última generación. Además gracias a su aporte financiero, es que podremos ofrecer las capacitaciones del año 2021 en forma totalmente gratuita para el público en general."
            });
            

            return sponsors;
        }
    }
}
