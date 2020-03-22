using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using XTC.Devops.Users;

namespace XTC.Devops.Qualities
{
    /// <summary>
    /// 测试用例
    /// </summary>
    public class TestCase : FullAuditedAggregateRoot<Guid, User>
    {
        public string Code { get; set; }
        public string FunPoint { get; set; }
    }
}
