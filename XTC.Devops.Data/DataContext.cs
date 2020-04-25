using Abp.EntityFrameworkCore;
using Abp.Extensions;
using Microsoft.EntityFrameworkCore;
using XTC.Devops.TestPlans;
using System.Linq;
using Abp.Runtime.Session;
using Abp.Reflection.Extensions;
using XTC.Devops.Projects;

namespace XTC.Devops.Data
{
    public class DataContext : AbpDbContext
    {
        #region 测试计划
        public DbSet<TestCase> TestCases { get; set; }
        #endregion

        #region 项目
        public DbSet<Project> Projects { get; set; }
        public DbSet<Demand> Demands { get; set; }
        #endregion

        private readonly IPrincipalAccessor _accessor;
        private readonly string _userCode;
        private readonly string _userName;

        //用于迁移数据
        //public DataContext(DbContextOptions options) : this(options, null)
        //{

        //}

        public DataContext(DbContextOptions<DataContext> options, IPrincipalAccessor accessor) : base(options)
        {
            _accessor = accessor;
            _userCode = _accessor?.Principal.Claims.FirstOrDefault(x => x.Type.ToLowerInvariant() == "UserCode".ToLowerInvariant())?.Value;
            _userName = _accessor?.Principal.Claims.FirstOrDefault(x => x.Type.ToLowerInvariant() == "UserName".ToLowerInvariant())?.Value;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).GetAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
