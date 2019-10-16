using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jeans.User.CoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jeans.User.CoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserModel userModel = new UserModel();

        [HttpGet]
        public IActionResult Get(int pageIndex, int pageSize)
        {
            IList<UserModel> results = userModel.GetList(pageIndex * pageSize).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return Ok(new
            {
                totalCount = pageIndex * pageSize,
                items = results
            });
        }
    }
}
