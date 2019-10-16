namespace Jeans.User.API.Models
{
    public class PageRequest
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 当前页条数
        /// </summary>
        public int PageSize { get; set; } = 10;
    }
}