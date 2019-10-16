using System.Collections.Generic;

namespace Jeans.WebCore.Models
{
    public class TableResponse<T>
    {
        public List<T> Data { get; set; }

        public int Total { get; set; }
    }
}
