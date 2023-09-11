using DormitoryApi.Application.IRepositories.IBedRepos;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;
using RestaurantFinalAPI.Persistance.Concreates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Concreates.Repositories.BedRepos
{
    public class BedReadRepository : RepositoryRead<Bed>, IBedReadRepository
    {
        public BedReadRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }

    public class BedWriteRepository : RepositoryWrite<Bed>, IBedWriteRepository
    {
        public BedWriteRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }
}
