using DormitoryApi.Application.IRepositories.IRoomRepos;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;
using RestaurantFinalAPI.Persistance.Concreates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Concreates.Repositories.RoomRepos
{
    public class RoomReadRepository : RepositoryRead<Room>, IRoomReadRepository
    {
        public RoomReadRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }

    public class RoomWriteRepository : RepositoryWrite<Room>, IRoomWriteRepository
    {
        public RoomWriteRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }
}
