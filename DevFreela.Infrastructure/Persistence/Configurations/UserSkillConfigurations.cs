using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class UserSkillConfigurations : IEntityTypeConfiguration<UserSkill>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserSkill> builder)
        {
            builder
                .ToTable("tb_userskill")
                .HasKey(u => u.Id);
        }
    }
}
