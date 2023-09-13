using DormitoryApi.Application.DTOs.TokenDTOs;
using DormitoryApi.Application.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.Abstraction.Services.Persistance.IUserService
{
    public interface IAuthoService
    {
        Task<Response<TokenDTO>> LoginAsync(string userNameOrEmail, string password, int accessTokenLifeTime, int refreshTokenMoreLife);
        Task<Response<TokenDTO>> LoginWithRefreshTokenAsync(string refreshToken, int accessTokenLifeTime, int refreshTokenMoreLife);
        Task<Response<bool>> LogOut(string userNameOrEmail);

        public Task<string> PasswordResetAsnyc(string email);
        public Task<bool> VerifyResetTokenAsync(string resetToken, string userId);
    }
}
