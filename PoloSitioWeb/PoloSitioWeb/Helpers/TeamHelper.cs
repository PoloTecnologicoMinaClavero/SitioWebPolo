using PoloSitioWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloSitioWeb.Helpers
{
    public static class TeamHelper
    {
        public static List<TeamMember> GetAll()
        {
            var teamMembers = new List<TeamMember>();

            var enterprises = EnterpriseHelper.GetAll();

            var incluit = enterprises.FirstOrDefault(x => x.Name == "IncluIT");
            var mantis = enterprises.FirstOrDefault(x => x.Name == "Mantis");
            var verne = enterprises.FirstOrDefault(x => x.Name == "Verne");

            #region Incluit
            teamMembers.Add(new TeamMember()
            {
                Name = "Agustin Fdeil",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Incluit/agusfdeil.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Ailen Iacoi",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Incluit/aileniacoi.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Alejo Suaya",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Incluit/alejo.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Carlos Moscoso",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Incluit/carlosmoscoso.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Esteban Guerra",
                Role = "Scrum Master",
                ImageUrl = "/assets/img/fotos/Incluit/estebanguerra.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Ezequiel Etchecoin",
                Role = "Developer - Team Leader",
                ImageUrl = "/assets/img/fotos/Incluit/ezeetchecoin.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Ezequiel Fdeil",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Incluit/ezefdeil.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Federico Sosa",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Incluit/fedesosa.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Ignacio Romero",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Incluit/ignacioromero.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Joaquin Mateos",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Incluit/joaco.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Julian Gonzalez",
                Role = "QA",
                ImageUrl = "/assets/img/fotos/Incluit/juliangonzalez.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Lautaro Brito",
                Role = "QA",
                ImageUrl = "/assets/img/fotos/Incluit/lauti.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Marcos Bustos",
                Role = "Developer - Team Leader",
                ImageUrl = "/assets/img/fotos/Incluit/marcosbustos.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Matias Lujan",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Incluit/matilujan.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Pamela Ochoa",
                Role = "Technical Leader",
                ImageUrl = "/assets/img/fotos/Incluit/pameochoa.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Priscila Guzman",
                Role = "QA",
                ImageUrl = "/assets/img/fotos/Incluit/priscila.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Ruben Benegas",
                Role = "Developer - Team Leader",
                ImageUrl = "/assets/img/fotos/Incluit/rubenbenegas.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Sofia Britos",
                Role = "QA",
                ImageUrl = "/assets/img/fotos/Incluit/sofiabritos.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Tomas Pereyra",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Incluit/tomas.jpeg",
                ImageDescription = "Member",
                Enterprise = incluit
            });
            #endregion


            #region Mantis
            teamMembers.Add(new TeamMember()
            {
                Name = "Franco Oviedo",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Mantis/francooviedo.jpeg",
                ImageDescription = "Member",
                Enterprise = mantis
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Luciano Valenciaga",
                Role = "Developer",
                ImageUrl = "/assets/img/fotos/Mantis/lucianovalenciaga.jpeg",
                ImageDescription = "Member",
                Enterprise = mantis
            });
            #endregion

            #region Verne
            teamMembers.Add(new TeamMember()
            {
                Name = "Emanuel Rojas",
                Role = "Operations",
                ImageUrl = "/assets/img/fotos/Verne/emanuelrojas.jpeg",
                ImageDescription = "Member",
                Enterprise = verne
            });
            teamMembers.Add(new TeamMember()
            {
                Name = "Mariana Rodriguez",
                Role = "Operations",
                ImageUrl = "/assets/img/fotos/Verne/marianarodriguez.jpeg",
                ImageDescription = "Member",
                Enterprise = verne
            });
            #endregion

            return CommonHelper.Desordenar(teamMembers).ToList();
        }
    }
}
