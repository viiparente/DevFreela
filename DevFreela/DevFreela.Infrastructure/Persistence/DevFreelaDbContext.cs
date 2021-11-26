using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu Projeto ASPNET CORE 0", "Descricao do projeto 0", 22, 03, 1000),
                 new Project("Meu Projeto ASPNET CORE 1", "Descricao do projeto 1", 22, 03, 2000),
                  new Project("Meu Projeto ASPNET CORE 2", "Descricao do projeto 2", 22, 03, 3000),
                   new Project("Meu Projeto ASPNET CORE 3", "Descricao do projeto 3", 22, 03, 4000)
            };

            Users = new List<User>
            {
                new User("Vinicius Parente","vd.parente@hotmail.com", new DateTime(1900, 03, 22)),
                new User("João Parente","joao.parente@hotmail.com", new DateTime(1900, 12, 11)),
                new User("Francisco Parente","fparente1@hotmail.com", new DateTime(1900, 12, 33)),
            };

            Skill = new List<Skill>
            {
                new Skill("ASPNET Core"),
                new Skill("Java"),
                new Skill("MongoDB")
            };
        }
        public List<Project> Projects { get; set; }

        public List<User> Users { get; set; }

        public List<Skill> Skill { get; set; }
    }
}
