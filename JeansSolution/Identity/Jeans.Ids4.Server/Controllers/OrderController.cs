using Jeans.Ids4.Server.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Jeans.Ids4.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderModel _order = new OrderModel();

        [HttpGet]
        public IActionResult Get(int pageIndex, int pageSize)
        {
            List<OrderModel> orders = null;

            return Ok(new
            {
                totalCount = pageIndex * pageSize,
                items = orders
            });
        }
    }
}
