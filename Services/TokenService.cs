﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Blog.Models;
using Microsoft.IdentityModel.Tokens;

namespace Blog.Services;

public class TokenService
{
    public string GenerateToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Configuration.JwtKey); // transforma em um array de bytes
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new(ClaimTypes.Name, "undersin"), // User.Identity.Name
                new(ClaimTypes.Role, "user"), // User.IsInRole
                new(ClaimTypes.Role, "admin"), // User.IsInRole
                new("fruta", "caju")
            }),
            Expires = DateTime.UtcNow.AddHours(8), // tempo de autorização
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key), // tipo da chave
                SecurityAlgorithms.HmacSha256Signature) // tipo de algoritimo - Sha256
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}