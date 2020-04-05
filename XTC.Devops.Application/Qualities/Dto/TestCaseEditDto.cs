using Abp.Domain.Entities;
using Abp.AutoMapper;
using System;

namespace XTC.Devops.Qualities.Dto
{
    [AutoMapTo(typeof(TestCase))]
    public class TestCaseEditDto : Entity<Guid>
    {
        public string Code { get; set; }
        public string FunPoint { get; set; }
    }
}
