using System;
using System.Collections.Generic;
using System.Text;

namespace XTC.Devops.UserClaims
{
    public interface IUserService
    {
        public string UserCode { get; }

        public string UserName { get; }
    }
}
