using DormitoryApi.Application.DTOs.DormitoryDTOs;
using DormitoryApi.Application.Models.ResponseModel;

namespace DormitoryApi.Application.Abstraction.Services.Persistance
{
    public interface IDormitorySevice
    {
        Task<Response<DormitoryCreateDTO>> AddDormitory(DormitoryCreateDTO model);
        Task<Response<bool>> DeleteDormitory(string Id);
        Task<Response<bool>> UpdateDormitory(DormitoryUpdateDTO model);

        Task<Response<List<DormitoryGetDTO>>> GetAllDormitory();
        Task<Response<DormitoryGetDTO>> GetDormitoryById(string Id);
        Task<Response<List<DormitoryGetDTO>>> GetAllDormitoryByUserId(string Id);
    }
}
