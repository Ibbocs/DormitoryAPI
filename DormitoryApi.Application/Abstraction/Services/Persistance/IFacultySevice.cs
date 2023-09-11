using DormitoryApi.Application.DTOs.FacultyDTOs;
using DormitoryApi.Application.Models.ResponseModel;

namespace DormitoryApi.Application.Abstraction.Services.Persistance
{
    public interface IFacultySevice
    {
        Task<Response<FacultyCreateDTO>> AddFaculty(FacultyCreateDTO model);
        Task<Response<bool>> DeleteFaculty(string Id);
        Task<Response<bool>> UpdateFaculty(FacultyUpdateDTO model);

        Task<Response<List<FacultyGetDTO>>> GetAllFaculty();
        Task<Response<FacultyGetDTO>> GetFacultyById(string Id);
        Task<Response<List<FacultyGetDTO>>> GetAllFacultyByUserId(string Id);
    }
}
