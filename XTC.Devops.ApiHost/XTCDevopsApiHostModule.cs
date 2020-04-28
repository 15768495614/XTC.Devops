using Abp.AspNetCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XTC.Devops.Application;
using XTC.Devops.Data;

namespace XTC.Devops
{
    /// <summary>
    /// Api模块
    /// </summary>
    [DependsOn(typeof(AbpAspNetCoreModule), typeof(XTCDevopsApplicationModule), typeof(XTCDevopsDataModule))]
    public class XTCDevopsApiHostModule : AbpModule
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XTCDevopsApiHostModule).GetAssembly());
        }
    }
}
