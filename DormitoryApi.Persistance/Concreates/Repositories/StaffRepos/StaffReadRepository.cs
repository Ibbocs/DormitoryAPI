using DormitoryApi.Application.IRepositories.IStaffRepos;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;
using RestaurantFinalAPI.Persistance.Concreates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Concreates.Repositories.StaffRepos
{
    public class StaffReadRepository : RepositoryRead<Staff>, IStaffReadRepository
    {
        public StaffReadRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }

    public class StaffWriteRepository : RepositoryWrite<Staff>, IStaffWriteRepository
    {
        public StaffWriteRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }
}
