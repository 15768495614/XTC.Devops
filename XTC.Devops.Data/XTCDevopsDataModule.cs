using Abp.EntityFrameworkCore;
using Abp.Modules;

namespace XTC.Devops.Data
{
    [DependsOn(typeof(AbpEntityFrameworkCoreModule), typeof(XTCDevopsCoreModule))]
    public class XTCDevopsDataModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XTCDevopsDataModule).Assembly);
        }
    }
}
