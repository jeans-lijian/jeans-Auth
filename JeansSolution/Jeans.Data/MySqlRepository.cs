using Jeans.Core.Domins;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeans.Data
{
    public class MySqlRepository<T> : IRepository<T> where T : BaseEntity
    {
    }
}
