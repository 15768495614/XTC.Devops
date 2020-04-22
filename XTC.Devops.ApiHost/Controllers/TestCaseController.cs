using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using XTC.Devops.TestPlans;
using XTC.Devops.TestPlans.Dto;

namespace XTC.Devops.ApiHost.Controllers
{
    [Route("api/testcase")]
    public class TestCaseController : BaseController
    {
        private readonly ITestCaseService _testCaseService;

        public TestCaseController(ITestCaseService testCaseService)
        {
            _testCaseService = testCaseService;
        }

        [HttpPost]
        public async Task<TestCaseDto> InsertAsync([FromBody]CreateTestCaseDto input)
        {
            return await _testCaseService.InsertAsync(input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync([FromRoute]Guid id)
        {
            await _testCaseService.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<TestCaseDto> UpdateAsync([FromBody]TestCaseEditDto input)
        {
            return await _testCaseService.UpdateAsync(input);
        }

        [HttpGet]
        public async Task<TestCaseDto[]> GetTestCasesAsync()
        {
            return await _testCaseService.GetTestCasesAsync();
        }
    }
}