using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Jeans.Ids4.Server.Data
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


        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "20210515",
                    Username = "jeans",
                    Password = "123456",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.Name, "LiJian"),
                        new Claim(JwtClaimTypes.GivenName, "Li"),
                        new Claim(JwtClaimTypes.FamilyName, "Jian"),
                        new Claim(JwtClaimTypes.Email, "lijiansoftware@163.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "http://github.com/jeans-lijian")
                    }
                }
            };
        }
    }
}
