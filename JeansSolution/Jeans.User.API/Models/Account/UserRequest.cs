using System;

namespace Jeans.User.API.Models.Account
{
    public class UserRequest
    {
        /// <summary>
        /// 标识符
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string EmpNo { get; set; }

        /// <summary>
        /// card
        /// </summary>
        public string Card { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// sex
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// birthday
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// department
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// room
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// 工作岗位
        /// </summary>
        public string Job { get; set; }

        /// <summary>
        /// email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// mobile
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// office
        /// </summary>
        public string OfficePhone { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime InductionDate { get; set; }

        /// <summary>
        /// 离职时间
        /// </summary>
        public DateTime? ResignDate { get; set; }

        /// <summary>
        /// school
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// 文化程度
        /// </summary>
        public string Education { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        public string JobAddress { get; set; }

        /// <summary>
        /// 职级
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// 健康状况
        /// </summary>
        public string HealthStatus { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// 是否使用
        /// </summary>
        public int IsUsed { get; set; }
    }
}