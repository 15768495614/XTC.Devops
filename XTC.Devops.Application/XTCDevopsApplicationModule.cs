using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace XTC.Devops.Application
{
    [DependsOn(typeof(AbpAutoMapperModule), typeof(XTCDevopsCoreModule))]
    public class XTCDevopsApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            var thisAssembly = typeof(XTCDevopsApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);
            Configuration.Modules.AbpAutoMapper().Configurators.Add(item => { item.AddMaps(thisAssembly); });
        }
    }
}
