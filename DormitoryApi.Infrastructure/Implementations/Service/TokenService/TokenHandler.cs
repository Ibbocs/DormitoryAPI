﻿using DormitoryApi.Application.Abstraction.Services.Infrastructure.TokenService;
using DormitoryApi.Application.DTOs.TokenDTOs;
using DormitoryApi.Domain.Entities.Autho;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Infrastructure.Implementations.Service.TokenService
{
    public class TokenHandler : ITokenHandler
    {
        readonly IConfiguration configuration;
        readonly UserManager<AppUser> userManager;

        public TokenHandler(IConfiguration _configuration, UserManager<AppUser> userManager)
        {
            this.configuration = _configuration;
            this.userManager = userManager;
        }


        public async Task<TokenDTO> CreateAccessToken(int minute, AppUser user)
        {
            TokenDTO tokenDTO = new TokenDTO();

            //Security key simmetrikliyini duzeldirik
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(configuration["Token:SecurityKey"]));

            SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
            };

            //Role verirem tokene
            var roles = await userManager.GetRolesAsync(user);
            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));


            //token konfigurasiyasi veririk
            tokenDTO.Expiration = DateTime.UtcNow.AddMinutes(minute);
            JwtSecurityToken securityToken = new(
                audience: configuration["Token:Audience"],
                issuer: configuration["Token:Issure"],
                expires: tokenDTO.Expiration, //life time
                notBefore: DateTime.UtcNow, //islemeye baslayacagi vaxt
                signingCredentials: signingCredentials,
                claims: claims
                );

            //Token Yaradiriq
            JwtSecurityTokenHandler tokenHandler = new();
            tokenDTO.AccessToken = tokenHandler.WriteToken(securityToken);

            //refresh token yaradib veririk
            tokenDTO.RefreshToken = CreateRefreshToken();

            return tokenDTO;
        }



        public string CreateRefreshToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(configuration["Token:RefreshTokenSecret"]); // Refresh token için gizli sifre
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var refreshToken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(refreshToken);
        }


        public string RefreshToken()
        {
            //xususi bir clase ile random edelerle RFT yaradiriq
            byte[] number = new byte[32];
            using RandomNumberGenerator randomNumber = RandomNumberGenerator.Create();
            randomNumber.GetBytes(number);
            return Convert.ToBase64String(number);
        }
    }
}
