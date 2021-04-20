using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace Jeans.Ids4.Server.Models
{
    /// <summary>
    /// IdentityServer
    /// </summary>
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

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
                },
                new Client
                {
                    ClientId="mvc_client",
                    ClientSecrets={ new Secret("secret".Sha256()) },
                    AllowedGrantTypes=GrantTypes.Code,
                    AllowedScopes={
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                    },
                    RedirectUris={ "http://localhost:60336/signin-oidc" },
                    PostLogoutRedirectUris={ "http://localhost:60336/signout-callback-oidc" }
                }
            };
        }
    }
}
