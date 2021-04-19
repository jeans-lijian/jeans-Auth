using Jeans.BaseData.WebApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Jeans.BaseData.WebApi.Handler;

namespace Jeans.BaseData.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Jwt
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(options =>
            //     {   
            //         //options.TokenValidationParameters = new TokenValidationParameters
            //         //{
            //         //    ValidateIssuer = true,
            //         //    ValidateAudience = true,
            //         //    ValidateLifetime = true,
            //         //    ValidateIssuerSigningKey = true,
            //         //    ValidIssuer = JwtConst.Issuer,
            //         //    ValidAudience = JwtConst.Audience,
            //         //    ClockSkew = TimeSpan.Zero,
            //         //    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtConst.SecretKey))
            //         //};
            //     });

            // IdentityServer4
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = "http://localhost:8080";
                    options.RequireHttpsMetadata = false;
                    options.ApiName = "basedata";
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Read", p => p.RequireClaim("scope", "basedata.read"));
            });

            services.AddControllers()
                    .AddJsonOptions(options =>
                    {
                        options.JsonSerializerOptions.PropertyNamingPolicy = null;
                    });

            services.AddSingleton<IAuthorizationHandler, TestHandler>();
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
