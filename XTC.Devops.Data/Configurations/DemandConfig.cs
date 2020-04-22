using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using XTC.Devops.Projects;

namespace XTC.Devops.Data.Configurations
{
    public class DemandConfig : IEntityTypeConfiguration<Demand>
    {
        public void Configure(EntityTypeBuilder<Demand> builder)
        {
            builder.HasMany(x => x.ChildDemands).WithOne(x => x.ParentDemand).HasForeignKey(x => x.ParentDemandId);
        }
    }
}
