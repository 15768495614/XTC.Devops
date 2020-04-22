using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using XTC.Devops.Projects;

namespace XTC.Devops.Data.Configurations
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasMany(x => x.Demands).WithOne(x => x.Project).HasForeignKey(x => x.ProjectId);
        }
    }
}
