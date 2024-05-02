﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using XP.GestaoInvestimentos.Domain;
using XP.GestaoInvestimentos.Domain.Auth;

namespace XP.GestaoInvestimentos.Services.Class
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IConfiguration _config;

        public UsuarioService(IConfiguration config)
        {
            _config = config;
        }

        public AuthenticateResponse Authenticate(UserAuth model)
        {
            string? usr = this._config.GetSection("JWTSettings:Username").Value;
            string? pwd = this._config.GetSection("JWTSettings:Password").Value;

            if (model.Username == usr && model.Password == pwd)
            {

                Usuario user = new Usuario
                {
                    Id = 1,
                    FirstName = "HCOR",
                    LastName = "TKS",
                    Username = usr,
                    Password = pwd
                };

                var token = generateJwtToken(user);
                return new AuthenticateResponse(user, token);
            }

            else { return null; }
        }

        private string generateJwtToken(Usuario user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWTSettings:Secret"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, user.Username)
            };

            var token = new JwtSecurityToken(_config["AppSettings:Issuer"],
                _config["AppSettings:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}