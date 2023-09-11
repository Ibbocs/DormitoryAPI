using AutoMapper;
using DormitoryApi.Application.Abstraction.Services.Persistance;
using DormitoryApi.Application.DTOs.FacultyDTOs;
using DormitoryApi.Application.IRepositories.IFacultyRepos;
using DormitoryApi.Application.Models.ResponseModel;
using DormitoryApi.Application.UnitOfWork;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;

namespace DormitoryApi.Persistance.Implementations.Services
{
    public class FacultyService : IFacultySevice
    {
        private readonly IFacultyReadRepository facultyRead;
        private readonly IFacultyWriteRepository facultyWrite;
        private readonly IUnitOfWork<Faculty> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public FacultyService(IFacultyReadRepository _facultyRead, IFacultyWriteRepository _facultyWrite, IUnitOfWork<Faculty> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.facultyRead = _facultyRead;
            this.facultyWrite = _facultyWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<FacultyCreateDTO>> AddFaculty(FacultyCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteFaculty(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<FacultyGetDTO>>> GetAllFaculty()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<FacultyGetDTO>>> GetAllFacultyByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<FacultyGetDTO>> GetFacultyById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateFaculty(FacultyUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
