using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XTC.Devops.Qualities;

namespace XTC.Devops.Data
{
    public class DataContext : AbpDbContext
    {
        public DbSet<TestCase> TestCases { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }
    }
}
