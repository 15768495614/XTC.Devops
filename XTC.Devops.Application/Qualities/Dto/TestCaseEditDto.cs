using Abp.Domain.Entities;
using Abp.AutoMapper;

namespace XTC.Devops.Qualities.Dto
{
    [AutoMapTo(typeof(TestCase))]
    public class TestCaseEditDto : Entity
    {
        public string Code { get; set; }
        public string FunPoint { get; set; }
    }
}
