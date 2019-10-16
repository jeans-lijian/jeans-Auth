using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jeans.WebCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jeans.WebCore.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}