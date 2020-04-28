using Abp.Application.Services;
using System;
using System.Threading.Tasks;
using XTC.Devops.TestPlans.Dto;

namespace XTC.Devops.TestPlans
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITestCaseService : IApplicationService
    {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<TestCaseDto> InsertAsync(CreateTestCaseDto input);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid id);
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<TestCaseDto> UpdateAsync(TestCaseEditDto input);
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        Task<TestCaseDto[]> GetTestCasesAsync();
    }
}
