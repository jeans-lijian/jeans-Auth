using Jeans.Core.Domins;

namespace Jeans.Core.Domains
{
    public class Users : BaseEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        public string QQ { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}