using Abp.Domain.Entities;

namespace XTC.Devops.Qualities.Dto
{
    public class TestCaseDto : Entity
    {
        public string Code { get; set; }
        public string FunPoint { get; set; }
    }
}
