using Abp.Domain.Entities;
using Abp.AutoMapper;
using System;

namespace XTC.Devops.TestPlans.Dto
{
    [AutoMapTo(typeof(TestCase))]
    public class TestCaseEditDto : Entity<Guid>
    {
        public string Code { get; set; }
        public string FunPoint { get; set; }
    }
}
