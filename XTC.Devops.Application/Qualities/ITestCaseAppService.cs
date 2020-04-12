using Abp.Application.Services;
using System;
using System.Threading.Tasks;
using XTC.Devops.Qualities.Dto;

namespace XTC.Devops.Qualities
{
    public interface ITestCaseAppService : IApplicationService
    {
        Task<TestCaseDto> InsertAsync(CreateTestCaseDto input);
        Task DeleteAsync(Guid id);
        Task<TestCaseDto> UpdateAsync(TestCaseEditDto input);
        Task<TestCaseDto[]> GetTestCasesAsync();
    }
}
