using AutoMapper;
using DormitoryApi.Application.Abstraction.Services.Persistance;
using DormitoryApi.Application.DTOs.StudentDTOs;
using DormitoryApi.Application.IRepositories.IStudentRepos;
using DormitoryApi.Application.Models.ResponseModel;
using DormitoryApi.Application.UnitOfWork;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;

namespace DormitoryApi.Persistance.Implementations.Services
{
    public class StudentService : IStudentSevice
    {
        private readonly IStudentReadRepository studentRead;
        private readonly IStudentWriteRepository studentWrite;
        private readonly IUnitOfWork<Student> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public StudentService(IStudentReadRepository _studentRead, IStudentWriteRepository _studentWrite, IUnitOfWork<Student> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.studentRead = _studentRead;
            this.studentWrite = _studentWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<StudentCreateDTO>> AddStudent(StudentCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteStudent(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<StudentGetDTO>>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<StudentGetDTO>>> GetAllStudentByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<StudentGetDTO>> GetStudentById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateStudent(StudentUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
