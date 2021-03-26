using PoloSitioWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloSitioWeb.Helpers
{
    public static class CommonHelper
    {
        public static IEnumerable<T> Desordenar<T>(IEnumerable<T> lista)
        {
            var r = new Random(DateTime.Now.Millisecond);
            return lista.OrderBy<T, int>((item) => r.Next());
        }
    }
}
