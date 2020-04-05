using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace XTC.Devops
{
    public abstract class AbpAggregateRoot<TPrimaryKey> : IEntity<TPrimaryKey>, IAbpCreationAudited, IHasCreationTime, IAbpDeletionAudited, IHasDeletionTime, IAbpModificationAudited, IHasModificationTime, ISoftDelete
    {
        /// <summary>
        /// 主键
        /// </summary>
        public TPrimaryKey Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        public string CreatorUserCode { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CreateByUser { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeletionTime { get; set; }

        /// <summary>
        /// 删除人工号
        /// </summary>
        public string DeleterUserCode { get; set; }

        /// <summary>
        /// 删除人姓名
        /// </summary>
        public string DeleteByUser { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// 最后修改人工号
        /// </summary>
        public string LastModifierUserCode { get; set; }

        /// <summary>
        /// 最后修改人姓名
        /// </summary>
        public string LastModifyByUser { get; set; }

        public bool IsTransient()
        {
            return true;
        }
    }

    public interface IAbpCreationAudited : IHasCreationTime
    {
        /// <summary>
        /// 创建人工号
        /// </summary>
        public string CreatorUserCode { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CreateByUser { get; set; }
    }

    public interface IAbpDeletionAudited : IHasDeletionTime, ISoftDelete
    {
        /// <summary>
        /// 删除人工号
        /// </summary>
        public string DeleterUserCode { get; set; }

        /// <summary>
        /// 删除人姓名
        /// </summary>
        public string DeleteByUser { get; set; }
    }

    public interface IAbpModificationAudited : IHasModificationTime
    {
        /// <summary>
        /// 最后修改人工号
        /// </summary>
        public string LastModifierUserCode { get; set; }

        /// <summary>
        /// 最后修改人姓名
        /// </summary>
        public string LastModifyByUser { get; set; }
    }


}
