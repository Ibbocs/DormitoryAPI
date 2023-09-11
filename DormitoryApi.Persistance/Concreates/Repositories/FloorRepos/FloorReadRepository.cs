using DormitoryApi.Application.IRepositories.IFloorRepos;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;
using RestaurantFinalAPI.Persistance.Concreates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Concreates.Repositories.FloorRepos
{
    public class FloorReadRepository : RepositoryRead<Floor>, IFloorReadRepository
    {
        public FloorReadRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }

    public class FloorWriteRepository : RepositoryWrite<Floor>, IFloorWriteRepository
    {
        public FloorWriteRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }
}
