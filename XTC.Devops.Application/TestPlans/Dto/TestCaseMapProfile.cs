using AutoMapper;

namespace XTC.Devops.TestPlans.Dto
{
    /// <summary>
    /// 测试用例映射文件
    /// </summary>
    public class TestCaseMapProfile : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public TestCaseMapProfile()
        {
            CreateMap<CreateTestCaseDto, TestCase>();
            CreateMap<TestCase, TestCaseDto>();
        }
    }
}
