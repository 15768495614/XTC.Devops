using Abp.Domain.Entities;
using System;

namespace XTC.Devops.TestPlans.Dto
{
    public class TestCaseDto : Entity<Guid>
    {
        public string Code { get; set; }
        public string FunPoint { get; set; }
    }
}
