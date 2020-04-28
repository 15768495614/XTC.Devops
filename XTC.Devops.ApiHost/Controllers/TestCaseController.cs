using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using XTC.Devops.TestPlans;
using XTC.Devops.TestPlans.Dto;

namespace XTC.Devops.ApiHost.Controllers
{
    /// <summary>
    /// 测试用例
    /// </summary>
    [Route("api/testcase")]
    public class TestCaseController : BaseController
    {
        private readonly ITestCaseService _testCaseService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="testCaseService"></param>
        public TestCaseController(ITestCaseService testCaseService)
        {
            _testCaseService = testCaseService;
        }

        /// <summary>
        /// 创建测试用例
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TestCaseDto> Insert([FromBody]CreateTestCaseDto input)
        {
            return await _testCaseService.InsertAsync(input);
        }

        /// <summary>
        /// 删除测试用例
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete([FromRoute]Guid id)
        {
            await _testCaseService.DeleteAsync(id);
        }

        /// <summary>
        /// 更新测试用例
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<TestCaseDto> Update([FromBody]TestCaseEditDto input)
        {
            return await _testCaseService.UpdateAsync(input);
        }

        /// <summary>
        /// 测试用例列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("list")]
        public async Task<TestCaseDto[]> GetTestCases()
        {
            return await _testCaseService.GetTestCasesAsync();
        }
    }
}