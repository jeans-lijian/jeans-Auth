using IdentityModel;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Jeans.Ids4.Server.Models
{
    /// <summary>
    /// IdentityServer
    /// </summary>
    public static class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("basedata", "basedata_service")
                {
                    Description="基础数据服务",
                    Scopes={ "basedata.admin","basedata.read","manager"}
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                //basedata
                new ApiScope(name: "basedata.admin", displayName: "可以查看和操作数据权限"),
                new ApiScope(name: "basedata.read", displayName: "只有查看数据的权限"),

                //shared
                new ApiScope(name:"manager",displayName:"超级管理员,最高权限")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId="hangfire_client",
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    ClientSecrets={
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes={ "basedata.read" }
                }
            };
        }
    }
}
