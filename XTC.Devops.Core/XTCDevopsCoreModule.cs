using Abp.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace XTC.Devops
{
    public class XTCDevopsCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XTCDevopsCoreModule).Assembly);
        }
    }
}
