using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace XTC.Devops.Projects
{
    /// <summary>
    /// 项目
    /// </summary>
    [Table("Project")]
    public class Project : AbpAggregateRoot<Guid>
    {
        public virtual ICollection<Demand> Demands { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Describe { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public string OwnerName { get; set; }

        public string OwnerCode { get; set; }
    }
}
