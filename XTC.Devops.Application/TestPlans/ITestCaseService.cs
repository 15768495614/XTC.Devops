using Abp.Application.Services;
using System;
using System.Threading.Tasks;
using XTC.Devops.TestPlans.Dto;

namespace XTC.Devops.TestPlans
{
    public interface ITestCaseService : IApplicationService
    {
        Task<TestCaseDto> InsertAsync(CreateTestCaseDto input);
        Task DeleteAsync(Guid id);
        Task<TestCaseDto> UpdateAsync(TestCaseEditDto input);
        Task<TestCaseDto[]> GetTestCasesAsync();
    }
}
