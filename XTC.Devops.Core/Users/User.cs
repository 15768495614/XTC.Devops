using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace XTC.Devops.Users
{
    public class User : IEntity<long>
    {
        public long Id { get; set; }

        public bool IsTransient()
        {
            return true;
        }
    }
}
