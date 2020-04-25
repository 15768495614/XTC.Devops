using Abp.AspNetCore;
using Abp.Modules;
using XTC.Devops.Application;
using XTC.Devops.Data;

namespace XTC.Devops
{
    [DependsOn(typeof(AbpAspNetCoreModule), typeof(XTCDevopsApplicationModule), typeof(XTCDevopsDataModule))]
    public class XTCDevopsApiHostModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XTCDevopsApiHostModule).Assembly);
        }
    }
}
