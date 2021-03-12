using PoloSitioWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloSitioWeb.Helpers
{
    public static class EnterprisesHelper
    {
        public static List<Enterprise> GetAll()
        {
            var enterprises = new List<Enterprise>();

            enterprises.Add(new Enterprise()
            {
                Name = "IncluIT",
                SiteUrl = "https://incluit.com",
                ImageUrl = "/assets/img/logos/Incluit.svg",
                ImageDescription = "IncluIT Logo"
            });
            enterprises.Add(new Enterprise()
            {
                Name = "Verne",
                SiteUrl = "https://www.vernegroup.com/",
                ImageUrl = "/assets/img/logos/Verne.png",
                ImageDescription = "Verne Logo"
            });
            enterprises.Add(new Enterprise()
            {
                Name = "Mantis",
                SiteUrl = "http://www.mantis.com.ar/",
                ImageUrl = "/assets/img/logos/Mantis-Azul.png",
                ImageDescription = "Mantis Logo"
            });


            return enterprises;
        }
    }
}
