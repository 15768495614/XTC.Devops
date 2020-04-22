using Abp.Application.Services;
using System;
using System.Threading.Tasks;
using XTC.Devops.TestPlans.Dto;
using Abp.Domain.Uow;
using Abp.Domain.Repositories;
using Abp.UI;
using Abp.Authorization;

namespace XTC.Devops.TestPlans
{
    [AbpAuthorize]
    public class TestCaseService : ApplicationService, ITestCaseService
    {
        private readonly IRepository<TestCase, Guid> _testCaseRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public TestCaseService(IRepository<TestCase, Guid> testCaseRepository
            , IUnitOfWorkManager unitOfWorkManager)
        {
            _testCaseRepository = testCaseRepository;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task<TestCaseDto> InsertAsync(CreateTestCaseDto input)
        {
            var entity = ObjectMapper.Map<TestCase>(input);
            await _testCaseRepository.InsertAsync(entity);
            return ObjectMapper.Map<TestCaseDto>(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _testCaseRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null) throw new UserFriendlyException("未找到记录!");
            await _testCaseRepository.DeleteAsync(entity);
        }

        public async Task<TestCaseDto> UpdateAsync(TestCaseEditDto input)
        {
            var oldEntity = await _testCaseRepository.FirstOrDefaultAsync(x => x.Id == input.Id);
            if (oldEntity == null) throw new UserFriendlyException("未找到记录!");
            var entity = ObjectMapper.Map(input, oldEntity);
            await _testCaseRepository.UpdateAsync(entity);
            return ObjectMapper.Map<TestCaseDto>(entity);
        }

        public async Task<TestCaseDto[]> GetTestCasesAsync()
        {
            var list = await _testCaseRepository.GetAllListAsync();
            return ObjectMapper.Map<TestCaseDto[]>(list);
        }
    }
}
