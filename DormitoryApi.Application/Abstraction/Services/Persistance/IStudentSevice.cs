using DormitoryApi.Application.DTOs.StudentDTOs;
using DormitoryApi.Application.Models.ResponseModel;

namespace DormitoryApi.Application.Abstraction.Services.Persistance
{
    public interface IStudentSevice
    {
        Task<Response<StudentCreateDTO>> AddStudent(StudentCreateDTO model);
        Task<Response<bool>> DeleteStudent(string Id);
        Task<Response<bool>> UpdateStudent(StudentUpdateDTO model);

        Task<Response<List<StudentGetDTO>>> GetAllStudent();
        Task<Response<StudentGetDTO>> GetStudentById(string Id);
        Task<Response<List<StudentGetDTO>>> GetAllStudentByUserId(string Id);
    }
}
