using Abp.Application.Services;
using System;
using System.Threading.Tasks;
using XTC.Devops.TestPlans.Dto;
using Abp.Domain.Uow;
using Abp.Domain.Repositories;
using Abp.UI;

namespace XTC.Devops.TestPlans
{
    /// <summary>
    /// 测试用例服务
    /// </summary>
    public class TestCaseService : ApplicationService, ITestCaseService
    {
        private readonly IRepository<TestCase, Guid> _testCaseRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="testCaseRepository"></param>
        public TestCaseService(IRepository<TestCase, Guid> testCaseRepository)
        {
            _testCaseRepository = testCaseRepository;
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<TestCaseDto> InsertAsync(CreateTestCaseDto input)
        {
            var entity = ObjectMapper.Map<TestCase>(input);
            await _testCaseRepository.InsertAsync(entity);
            return ObjectMapper.Map<TestCaseDto>(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteAsync(Guid id)
        {
            var entity = await _testCaseRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null) throw new UserFriendlyException("未找到记录!");
            await _testCaseRepository.DeleteAsync(entity);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<TestCaseDto> UpdateAsync(TestCaseEditDto input)
        {
            var oldEntity = await _testCaseRepository.FirstOrDefaultAsync(x => x.Id == input.Id);
            if (oldEntity == null) throw new UserFriendlyException("未找到记录!");
            var entity = ObjectMapper.Map(input, oldEntity);
            await _testCaseRepository.UpdateAsync(entity);
            return ObjectMapper.Map<TestCaseDto>(entity);
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public async Task<TestCaseDto[]> GetTestCasesAsync()
        {
            var list = await _testCaseRepository.GetAllListAsync();
            return ObjectMapper.Map<TestCaseDto[]>(list);
        }
    }
}
