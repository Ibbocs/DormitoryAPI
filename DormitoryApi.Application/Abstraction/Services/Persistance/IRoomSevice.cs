using DormitoryApi.Application.DTOs.RoomDTOs;
using DormitoryApi.Application.Models.ResponseModel;

namespace DormitoryApi.Application.Abstraction.Services.Persistance
{
    public interface IRoomSevice
    {
        Task<Response<RoomCreateDTO>> AddRoom(RoomCreateDTO model);
        Task<Response<bool>> DeleteRoom(string Id);
        Task<Response<bool>> UpdateRoom(RoomUpdateDTO model);

        Task<Response<List<RoomGetDTO>>> GetAllRoom();
        Task<Response<RoomGetDTO>> GetRoomById(string Id);
        Task<Response<List<RoomGetDTO>>> GetAllRoomByUserId(string Id);
    }
}
