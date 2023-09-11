using DormitoryApi.Application.IRepositories.IFacultyRepos;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;
using RestaurantFinalAPI.Persistance.Concreates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Concreates.Repositories.FacultyRepos
{
    public class FacultyReadRepository : RepositoryRead<Faculty>, IFacultyReadRepository
    {
        public FacultyReadRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }

    public class FacultyWriteRepository : RepositoryWrite<Faculty>, IFacultyWriteRepository
    {
        public FacultyWriteRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }
}
