using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace XTC.Devops.Projects
{
    /// <summary>
    /// 需求
    /// </summary>
    [Table("Demand")]
    public class Demand : AbpAggregateRoot<Guid>
    {
        /// <summary>
        /// 项目Id
        /// </summary>
        public Guid ProjectId { get; set; }

        [JsonIgnore]
        public virtual Project Project { get; set; }

        public Guid? ParentDemandId { get; set; }

        [JsonIgnore]
        public virtual Demand ParentDemand { get; set; }

        public virtual ICollection<Demand> ChildDemands { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Describe { get; set; }
        

    }
}
