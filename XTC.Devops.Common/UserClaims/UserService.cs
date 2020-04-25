using Abp.Dependency;
using Abp.Runtime.Session;
using System;
using System.Linq;

namespace XTC.Devops.UserClaims
{
    public class UserService : IUserService, ITransientDependency
    {
        public string UserCode { get; }

        public string UserName { get; }

        private readonly IPrincipalAccessor _accessor;

        public UserService(IPrincipalAccessor accessor)
        {
            _accessor = accessor;
            UserCode = _accessor.Principal.Claims.FirstOrDefault(x => x.Type.ToLowerInvariant() == "UserCode".ToLowerInvariant())?.Value;
            UserName = _accessor.Principal.Claims.FirstOrDefault(x => x.Type.ToLowerInvariant() == "UserName".ToLowerInvariant())?.Value;
        }
    }
}
