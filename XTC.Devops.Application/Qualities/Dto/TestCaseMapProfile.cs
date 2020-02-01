using AutoMapper;

namespace XTC.Devops.Qualities.Dto
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
