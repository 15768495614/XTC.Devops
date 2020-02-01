using Abp.Domain.Entities.Auditing;
using XTC.Devops.Users;

namespace XTC.Devops.Qualities
{
    /// <summary>
    /// 测试用例
    /// </summary>
    public class TestCase : FullAuditedEntity<int, User>
    {
        public string Code { get; set; }
        public string FunPoint { get; set; }
    }
}
