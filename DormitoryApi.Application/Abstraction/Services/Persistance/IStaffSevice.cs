using DormitoryApi.Application.DTOs.StaffDTOs;
using DormitoryApi.Application.Models.ResponseModel;

namespace DormitoryApi.Application.Abstraction.Services.Persistance
{
    public interface IStaffSevice
    {
        Task<Response<StaffCreateDTO>> AddStaff(StaffCreateDTO model);
        Task<Response<bool>> DeleteStaff(string Id);
        Task<Response<bool>> UpdateStaff(StaffUpdateDTO model);

        Task<Response<List<StaffGetDTO>>> GetAllStaff();
        Task<Response<StaffGetDTO>> GetStaffById(string Id);
        Task<Response<List<StaffGetDTO>>> GetAllStaffByUserId(string Id);
    }
}
