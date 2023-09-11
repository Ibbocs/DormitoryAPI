using DormitoryApi.Application.IRepositories.IStudentRepos;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;
using RestaurantFinalAPI.Persistance.Concreates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Concreates.Repositories.StudentRepos
{
    public class StudentReadRepository : RepositoryRead<Student>, IStudentReadRepository
    {
        public StudentReadRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }

    public class StudentWriteRepository : RepositoryWrite<Student>, IStudentWriteRepository
    {
        public StudentWriteRepository(DormitoryDbContext _dormitoryAPIContext) : base(_dormitoryAPIContext)
        {
        }
    }
}
