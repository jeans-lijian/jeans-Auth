using Jeans.Jwt.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Jeans.Jwt.Server.Controllers
{
    [ApiController]
    [ControllerName("auth")]
    [Route("api/jwt/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("token")]
        public IActionResult CreateTokenAsync(LoginModel input)
        {
            if (input != null &&
                !string.IsNullOrWhiteSpace(input.UserName) &&
                !string.IsNullOrWhiteSpace(input.Password))
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtConst.SecretKey));
                var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Name,input.UserName),
                    new Claim("Role",string.Join(",",new []{ "Admin","Study"}))
                };

                var token = new JwtSecurityToken(issuer: JwtConst.Issuer,
                     audience: JwtConst.Audience,
                     claims: claims,
                     expires: DateTime.Now.AddMinutes(5),
                     signingCredentials: credential);

                string result_token = new JwtSecurityTokenHandler().WriteToken(token);

                return Ok(new
                {
                    AccessToken = result_token
                });
            }

            return BadRequest(new
            {
                Error = "invalid_request",
                Error_Description = "username or password error."
            });
        }
    }
}
