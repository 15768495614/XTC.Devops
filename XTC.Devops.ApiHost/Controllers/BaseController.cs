using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Abp.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace XTC.Devops.ApiHost.Controllers
{
    [AbpAuthorize]
    [ApiController]
    public class BaseController : AbpController
    {
        
    }
}