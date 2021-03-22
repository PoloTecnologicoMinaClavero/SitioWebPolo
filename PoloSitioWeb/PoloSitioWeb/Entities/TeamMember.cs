using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloSitioWeb.Entities
{
    public class TeamMember
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string ImageUrl { get; set; }        
        public string ImageDescription { get; set; }
        public Enterprise Enterprise { get; set; }
    }
}
