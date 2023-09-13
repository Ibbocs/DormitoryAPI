using DormitoryApi.Application.DTOs.TokenDTOs;
using DormitoryApi.Domain.Entities.Autho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.Abstraction.Services.Infrastructure.TokenService
{
    public interface ITokenHandler
    {
        Task<TokenDTO> CreateAccessToken(int minute, AppUser user);
        string CreateRefreshToken();
    }
}
