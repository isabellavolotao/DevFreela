using DevFreela.Core.Entities;
using System.Collections.Generic;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("ASPNET Core project", "Description of project", 1, 1, 10000),
                new Project("Another ASPNET Core project", "Antoher description of project", 1, 1, 20000),
                new Project("Last ASPNET Core project", "Last description of project", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Isabella Teste 1", "isabella1@teste.com.br", new DateTime(2000, 1, 3)),
                new User("Isabella Teste 2", "isabella2@teste.com.br", new DateTime(1999, 2, 2)),
                new User("Isabella Teste 3", "isabella3@teste.com.br", new DateTime(2001, 3, 1))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
