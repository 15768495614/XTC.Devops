using Abp.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace XTC.Devops.Data
{
    [DependsOn(typeof(XTCDevopsCoreModule))]
    public class XTCDevopsDataModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XTCDevopsDataModule).Assembly);
        }
    }
}
