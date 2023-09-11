using AutoMapper;
using DormitoryApi.Application.Abstraction.Services.Persistance;
using DormitoryApi.Application.DTOs.DormitoryDTOs;
using DormitoryApi.Application.IRepositories.IDormitoryRepos;
using DormitoryApi.Application.Models.ResponseModel;
using DormitoryApi.Application.UnitOfWork;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;

namespace DormitoryApi.Persistance.Implementations.Services
{
    public class DormitoryService : IDormitorySevice
    {
        private readonly IDormitoryReadRepository dormitoryRead;
        private readonly IDormitoryWriteRepository dormitoryWrite;
        private readonly IUnitOfWork<Dormitory> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public DormitoryService(IDormitoryReadRepository _dormitoryRead, IDormitoryWriteRepository _dormitoryWrite, IUnitOfWork<Dormitory> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.dormitoryRead = _dormitoryRead;
            this.dormitoryWrite = _dormitoryWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<DormitoryCreateDTO>> AddDormitory(DormitoryCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteDormitory(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<DormitoryGetDTO>>> GetAllDormitory()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<DormitoryGetDTO>>> GetAllDormitoryByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<DormitoryGetDTO>> GetDormitoryById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateDormitory(DormitoryUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
