using DormitoryApi.Application.DTOs.FloorDTOs;
using DormitoryApi.Application.Models.ResponseModel;

namespace DormitoryApi.Application.Abstraction.Services.Persistance
{
    public interface IFloorSevice
    {
        Task<Response<FloorCreateDTO>> AddFloor(FloorCreateDTO model);
        Task<Response<bool>> DeleteFloor(string Id);
        Task<Response<bool>> UpdateFloor(FloorUpdateDTO model);

        Task<Response<List<FloorGetDTO>>> GetAllFloor();
        Task<Response<FloorGetDTO>> GetFloorById(string Id);
        Task<Response<List<FloorGetDTO>>> GetAllFloorByUserId(string Id);
    }
}
