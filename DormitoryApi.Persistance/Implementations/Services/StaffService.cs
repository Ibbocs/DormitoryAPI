using AutoMapper;
using DormitoryApi.Application.Abstraction.Services.Persistance;
using DormitoryApi.Application.DTOs.StaffDTOs;
using DormitoryApi.Application.IRepositories.IStaffRepos;
using DormitoryApi.Application.Models.ResponseModel;
using DormitoryApi.Application.UnitOfWork;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;

namespace DormitoryApi.Persistance.Implementations.Services
{
    public class StaffService : IStaffSevice
    {
        private readonly IStaffReadRepository staffRead;
        private readonly IStaffWriteRepository staffWrite;
        private readonly IUnitOfWork<Staff> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public StaffService(IStaffReadRepository _staffRead, IStaffWriteRepository _staffWrite, IUnitOfWork<Staff> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.staffRead = _staffRead;
            this.staffWrite = _staffWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<StaffCreateDTO>> AddStaff(StaffCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteStaff(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<StaffGetDTO>>> GetAllStaff()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<StaffGetDTO>>> GetAllStaffByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<StaffGetDTO>> GetStaffById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateStaff(StaffUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
