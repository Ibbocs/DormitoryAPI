using DormitoryApi.Application.IRepositories.IDormitoryRepos;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;
using RestaurantFinalAPI.Persistance.Concreates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Concreates.Repositories.DormitoryRepos
{
    public class DormitoryReadRepository : RepositoryRead<Dormitory>, IDormitoryReadRepository
    {
        public DormitoryReadRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }

    public class DormitoryWriteRepository : RepositoryWrite<Dormitory>, IDormitoryWriteRepository
    {
        public DormitoryWriteRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }
}
