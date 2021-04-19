using Microsoft.Extensions.Options;
using PoloSitioWeb.Configs;
using PoloSitioWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloSitioWeb.Helpers
{
    public static class CounterHelper
    {
        public static Counters GetCounts()
        {
            var counters = Startup.StaticConfiguration.GetSection("ContadoresConfig");

            return new Counters
            {
                CantidadCursosDictados = Convert.ToInt32(counters["CantidadCursosDictados"]),
                CantidadProyectos = Convert.ToInt32(counters["CantidadProyectos"]),
                CantidadTrabajando = Convert.ToInt32(counters["CantidadTrabajando"]),
                Empresas = Convert.ToInt32(counters["Empresas"]),
            };

        }
    }
}
