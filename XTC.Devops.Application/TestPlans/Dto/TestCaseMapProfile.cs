using AutoMapper;

namespace XTC.Devops.TestPlans.Dto
{
    public class TestCaseMapProfile : Profile
    {
        public TestCaseMapProfile()
        {
            CreateMap<CreateTestCaseDto, TestCase>();
            CreateMap<TestCase, TestCaseDto>();
        }
    }
}
