using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeans.User.Core
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// 标识符
        /// </summary>
        public int Id { get; set; }
    }
}