using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace XTC.Devops.Qualities
{
    /// <summary>
    /// 测试用例
    /// </summary>
    public class TestCase : AbpAggregateRoot<Guid>
    {
        public string Code { get; set; }
        public string FunPoint { get; set; }
    }
}
