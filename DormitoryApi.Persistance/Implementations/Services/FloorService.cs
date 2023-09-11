using AutoMapper;
using DormitoryApi.Application.Abstraction.Services.Persistance;
using DormitoryApi.Application.DTOs.FloorDTOs;
using DormitoryApi.Application.IRepositories.IFloorRepos;
using DormitoryApi.Application.Models.ResponseModel;
using DormitoryApi.Application.UnitOfWork;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;

namespace DormitoryApi.Persistance.Implementations.Services
{
    public class FloorService : IFloorSevice
    {
        private readonly IFloorReadRepository floorRead;
        private readonly IFloorWriteRepository floorWrite;
        private readonly IUnitOfWork<Floor> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public FloorService(IFloorReadRepository _floorRead, IFloorWriteRepository _floorWrite, IUnitOfWork<Floor> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.floorRead = _floorRead;
            this.floorWrite = _floorWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<FloorCreateDTO>> AddFloor(FloorCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteFloor(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<FloorGetDTO>>> GetAllFloor()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<FloorGetDTO>>> GetAllFloorByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<FloorGetDTO>> GetFloorById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateFloor(FloorUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
