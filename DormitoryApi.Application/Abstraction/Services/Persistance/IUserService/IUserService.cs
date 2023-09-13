using DormitoryApi.Application.DTOs.UserDTOs;
using DormitoryApi.Application.Models.ResponseModel;
using DormitoryApi.Domain.Entities.Autho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.Abstraction.Services.Persistance.IUserService
{
    public interface IUserService
    {
        Task<Response<CreateUserResponseDTO>> CreateAsync(CreateUserDto model);
        Task UpdateRefreshToken(string refreshToken, AppUser user, DateTime accessTokenDate, int refreshTokenMoreLifeMinute);
        public Task UpdatePasswordAsync(string userId, string resetToken, string newPassword);

        public Task<Response<List<UserGetDTO>>> GetAllUsersAsync();
        public Task<Response<bool>> AssignRoleToUserAsnyc(string userId, string[] roles);
        public Task<Response<string[]>> GetRolesToUserAsync(string userIdOrName);
        public Task<Response<bool>> DeleteUserAsync(string userIdOrName);
        public Task<Response<bool>> UpdateUserAsync(UserUpdateDTO model);
    }
}
