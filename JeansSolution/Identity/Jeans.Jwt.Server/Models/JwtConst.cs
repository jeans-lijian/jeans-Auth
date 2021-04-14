namespace Jeans.Jwt.Server.Models
{
    public class JwtConst
    {
        /// <summary>
        /// 发行者
        /// </summary>
        public const string Issuer = "Jeans";

        /// <summary>
        /// 主题
        /// </summary>
        public const string Subject = "Jwt授权";

        /// <summary>
        /// 观众
        /// </summary>
        public const string Audience = "Jeans";

        public const string SecretKey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDI2a2EJ7m872v0afyoSDJT2o1+SitIeJSWtLJU8/Wz2m7gStexajkeD+Lka6DSTy8gt9UwfgVQo6uKjVLG5Ex7PiGOODVqAEghBuS7JzIYU5RvI543nNDAPfnJsas96mSA7L/mD7RTE2drj6hf3oZjJpMPZUQI/B1Qjb5H3K3PNwIDAQAB";
    }
}
