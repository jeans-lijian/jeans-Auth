using System;
using System.Collections.Generic;

namespace Jeans.Ids4.Server.Models
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

    }
}
