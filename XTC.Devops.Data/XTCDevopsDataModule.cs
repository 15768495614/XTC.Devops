using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace XTC.Devops.Data
{
    [DependsOn(typeof(AbpEntityFrameworkCoreModule), typeof(XTCDevopsCoreModule), typeof(XTCDevopsCommonModule))]
    public class XTCDevopsDataModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XTCDevopsDataModule).GetAssembly());
        }
    }
}
