using Abp.Application.Services;
using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XTC.Devops.Qualities.Dto;
using Abp;
using Abp.Domain.Uow;
using Abp.Domain.Repositories;

namespace XTC.Devops.Qualities
{
    public class TestCaseAppService : ApplicationService, ITestCaseAppService
    {
        private readonly IRepository< TestCase, Guid> _testCaseRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public TestCaseAppService(IRepository<TestCase, Guid> testCaseRepository, IUnitOfWorkManager unitOfWorkManager)
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

        public async Task<TestCaseDto[]> GetTestCase()
        {
            var list = await _testCaseRepository.GetAllListAsync();
            return ObjectMapper.Map<TestCaseDto[]>(list);
        }

        public async Task<TestCaseDto> UpdateTestCase()
        {
            var editDto = new TestCaseEditDto { Code = "16546", FunPoint = "5476554" };
            //模拟旧实体
            var oldEntity = new TestCase { CreatorUserId = 2145, CreationTime = DateTime.Now };
            await _unitOfWorkManager.Current.SaveChangesAsync();//先保存
            var entity = ObjectMapper.Map(editDto, oldEntity);//从editDto定义的属性映射到Entity中，原来的部分属性值保留
            return ObjectMapper.Map<TestCaseDto>(entity);
        }
    }
}
