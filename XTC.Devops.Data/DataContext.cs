using Abp.EntityFrameworkCore;
using Abp.Extensions;
using Microsoft.EntityFrameworkCore;
using XTC.Devops.Qualities;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace XTC.Devops.Data
{
    public class DataContext : AbpDbContext
    {
        public DbSet<TestCase> TestCases { get; set; }

        private readonly IHttpContextAccessor _accessor;
        private readonly string _userCode;
        private readonly string _userName;

        public DataContext(DbContextOptions options, IHttpContextAccessor accessor) : base(options)
        {
            _accessor = accessor;
            _userCode = _accessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type.ToLowerInvariant() == "UserCode".ToLowerInvariant())?.Value;
            _userName = _accessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type.ToLowerInvariant() == "UserName".ToLowerInvariant())?.Value;
        }

        protected override void SetCreationAuditProperties(object entityAsObj, long? userId)
        {
            if (entityAsObj is IAbpCreationAudited)
            {
                var entity = entityAsObj.As<IAbpCreationAudited>();
                if (entity.CreatorUserCode.IsNullOrEmpty() || entity.CreateByUser.IsNullOrEmpty())
                {
                    entity.CreatorUserCode = _userCode;
                    entity.CreateByUser = _userName;
                }
            }
            base.SetCreationAuditProperties(entityAsObj, userId);
        }

        protected override void SetDeletionAuditProperties(object entityAsObj, long? userId)
        {
            if (entityAsObj is IAbpDeletionAudited)
            {
                var entity = entityAsObj.As<IAbpDeletionAudited>();
                if (entity.DeleterUserCode.IsNullOrEmpty() || entity.DeleteByUser.IsNullOrEmpty())
                {
                    entity.DeleterUserCode = _userCode;
                    entity.DeleteByUser = _userName;
                }
            }
            base.SetDeletionAuditProperties(entityAsObj, userId);
        }

        protected override void SetModificationAuditProperties(object entityAsObj, long? userId)
        {
            if (entityAsObj is IAbpModificationAudited)
            {
                var entity = entityAsObj.As<IAbpModificationAudited>();
                if (entity.LastModifierUserCode.IsNullOrEmpty() || entity.LastModifyByUser.IsNullOrEmpty())
                {
                    entity.LastModifierUserCode = _userCode;
                    entity.LastModifyByUser = _userName;
                }
            }
            base.SetModificationAuditProperties(entityAsObj, userId);
        }
    }
}
