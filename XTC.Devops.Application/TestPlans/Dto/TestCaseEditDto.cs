using Abp.Domain.Entities;
using Abp.AutoMapper;
using System;

namespace XTC.Devops.TestPlans.Dto
{
    /// <summary>
    /// 更新测试用例Dto
    /// </summary>
    [AutoMapTo(typeof(TestCase))]
    public class TestCaseEditDto : Entity<Guid>
    {
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 功能点
        /// </summary>
        public string FunPoint { get; set; }
    }
}
