using Abp.Domain.Entities;
using System;

namespace XTC.Devops.TestPlans.Dto
{
    /// <summary>
    /// 测试用例详情Dto
    /// </summary>
    public class TestCaseDto : Entity<Guid>
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
