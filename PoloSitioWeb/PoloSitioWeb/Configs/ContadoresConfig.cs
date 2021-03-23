using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloSitioWeb.Configs
{
    public class ContadoresConfig
    {
        public string FechaInicio { set; get; }
        public int CandtidadTrabajando { set; get; }
        public int CandtidadProyectos { set; get; }
        public int CandtidadCursosDictados { set; get; }

        public int DiasExistenciaPolo => GetDiasExistenciaPolo();

        private int GetDiasExistenciaPolo()
        {
            try
            {
                return (int)(DateTime.Now - Convert.ToDateTime(FechaInicio)).TotalDays;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
