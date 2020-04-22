using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace XTC.Devops.TestPlans
{
    /// <summary>
    /// 测试用例
    /// </summary>
    [Table("TestCase")]
    public class TestCase : AbpAggregateRoot<Guid>
    {
        public string Code { get; set; }
        public string FunPoint { get; set; }
    }
}
