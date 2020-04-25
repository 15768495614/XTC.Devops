using Abp.EntityFrameworkCore;
using Abp.Extensions;
using Microsoft.EntityFrameworkCore;
using XTC.Devops.TestPlans;
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

        public UserClaims.IUserService UserService { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void SetCreationAuditProperties(object entityAsObj, long? userId)
        {
            if (entityAsObj is IAbpCreationAudited)
            {
                var entity = entityAsObj.As<IAbpCreationAudited>();
                if (entity.CreatorUserCode.IsNullOrEmpty() || entity.CreateByUser.IsNullOrEmpty())
                {
                    entity.CreatorUserCode = UserService.UserCode;
                    entity.CreateByUser = UserService.UserName;
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
                    entity.DeleterUserCode = UserService.UserCode;
                    entity.DeleteByUser = UserService.UserName;
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
                    entity.LastModifierUserCode = UserService.UserCode;
                    entity.LastModifyByUser = UserService.UserName;
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
