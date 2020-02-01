using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.EntityFrameworkCore;
using Abp.Modules;
using Microsoft.Extensions.Configuration;
using XTC.Devops.Application;
using XTC.Devops.Data;

namespace XTC.Devops
{
    [DependsOn(typeof(AbpAspNetCoreModule), typeof(AbpEntityFrameworkCoreModule), typeof(XTCDevopsApplicationModule), typeof(XTCDevopsDataModule))]
    public class XTCDevopsApiHostModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = GetConnectionString("Default");
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XTCDevopsApiHostModule).Assembly);
            Configuration.Modules.AbpAspNetCore().CreateControllersForAppServices(typeof(XTCDevopsApplicationModule).Assembly);
        }

        public string GetConnectionString(string key)
        {
            return "Server=localhost; Database=Devops; Trusted_Connection=True;";
        }
    }
}
