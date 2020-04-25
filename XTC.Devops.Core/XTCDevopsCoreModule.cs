using Abp.Modules;
using Abp.Reflection.Extensions;

namespace XTC.Devops
{
    public class XTCDevopsCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XTCDevopsCoreModule).GetAssembly());
        }
    }
}
