using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jeans.Order.CoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jeans.Order.CoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderModel _order = new OrderModel();

        [HttpGet]
        public IActionResult Get(int pageIndex, int pageSize)
        {
            List<OrderModel> orders = _order.GetList(pageIndex * pageSize).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return Ok(new
            {
                totalCount = pageIndex * pageSize,
                items = orders
            });
        }
    }
}
