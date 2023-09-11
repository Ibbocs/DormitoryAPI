using AutoMapper;
using DormitoryApi.Application.Abstraction.Services.Persistance;
using DormitoryApi.Application.DTOs.RoomDTOs;
using DormitoryApi.Application.IRepositories.IRoomRepos;
using DormitoryApi.Application.Models.ResponseModel;
using DormitoryApi.Application.UnitOfWork;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;

namespace DormitoryApi.Persistance.Implementations.Services
{
    public class RoomService : IRoomSevice
    {
        private readonly IRoomReadRepository roomRead;
        private readonly IRoomWriteRepository roomWrite;
        private readonly IUnitOfWork<Room> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public RoomService(IRoomReadRepository _roomRead, IRoomWriteRepository _roomWrite, IUnitOfWork<Room> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.roomRead = _roomRead;
            this.roomWrite = _roomWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<RoomCreateDTO>> AddRoom(RoomCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteRoom(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<RoomGetDTO>>> GetAllRoom()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<RoomGetDTO>>> GetAllRoomByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<RoomGetDTO>> GetRoomById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateRoom(RoomUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
