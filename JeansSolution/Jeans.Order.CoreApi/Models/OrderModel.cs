using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeans.Order.CoreApi.Models
{
    public class OrderModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 订单名
        /// </summary>
        public string OrderName { get; private set; }

        /// <summary>
        /// 订单总数量
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 订单日期
        /// </summary>
        public DateTime OrderDateTime { get; set; }


        public List<OrderModel> GetList(int count)
        {
            Randomizer.Seed = new Random(123456);
            var users = new Faker<OrderModel>()
               .RuleFor(c => c.Id, Guid.NewGuid())
               .RuleFor(c => c.OrderName, f => f.Commerce.ProductName())
               .RuleFor(c => c.TotalCount, f => f.Random.Number(10, 50))
               .RuleFor(c => c.OrderDateTime, f => f.Date.Recent());

            return users.Generate(count);
        }
    }
}
