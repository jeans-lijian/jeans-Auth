using System;

namespace Jeans.Core.Domins
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// create person
        /// </summary>
        public string CreatePerson { get; set; }

        /// <summary>
        /// create date
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// update person
        /// </summary>
        public string ModifyPerson { get; set; }

        /// <summary>
        /// update date
        /// </summary>
        public DateTime ModifyDate { get; set; }
    }
}
