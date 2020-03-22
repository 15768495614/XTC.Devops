using Abp.Application.Services;
using System.Threading.Tasks;
using XTC.Devops.Qualities.Dto;

namespace XTC.Devops.Qualities
{
    public interface ITestCaseAppService: IApplicationService
    {
        Task<TestCaseDto> InsertAsync(CreateTestCaseDto input);
        Task<TestCaseDto[]> GetTestCase();
        Task<TestCaseDto> UpdateTestCase();
    }
}
