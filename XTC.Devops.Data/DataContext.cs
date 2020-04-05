using Abp.EntityFrameworkCore;
using Abp.Events.Bus.Entities;
using Abp.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using XTC.Devops.Qualities;

namespace XTC.Devops.Data
{
    public class DataContext : AbpDbContext
    {
        public DbSet<TestCase> TestCases { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void SetCreationAuditProperties(object entityAsObj, long? userId)
        {
            if (entityAsObj is IAbpCreationAudited)
            {
                var entity = entityAsObj.As<IAbpCreationAudited>();
                if (entity.CreatorUserCode.IsNullOrEmpty() || entity.CreateByUser.IsNullOrEmpty())
                {
                    entity.CreatorUserCode = "1|K0000221";
                    entity.CreateByUser = "梁灿林";
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
                    entity.DeleterUserCode = "1|K0000221";
                    entity.DeleteByUser = "梁灿林";
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
                    entity.LastModifierUserCode = "1|K0000221";
                    entity.LastModifyByUser = "梁灿林";
                }
            }
            base.SetModificationAuditProperties(entityAsObj, userId);
        }
    }
}
