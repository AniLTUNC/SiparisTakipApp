using SipsisBLL.Repsitory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Services.Implement;

namespace SipsisAdmin.Controllers
{
    public class BaseController : Controller
    {
        protected EntityServices service = new EntityServices();
    }
}