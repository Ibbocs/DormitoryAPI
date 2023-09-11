using DormitoryApi.Application.UnitOfWork;
using DormitoryApi.Domain.Entities.Common;
using DormitoryApi.Persistance.Context;
using RestaurantFinalAPI.Application.IRepositories;
using RestaurantFinalAPI.Persistance.Concreates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.UnitOfWork
{
    public class UnitOfWork<TRepo> : IUnitOfWork<TRepo> where TRepo : BaseEntity
    {
        private readonly DormitoryDbContext _dbContext;

        private IRepository<TRepo> myRepo;

        public UnitOfWork(DormitoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<TRepo> Repository
        {
            get
            {
                if (myRepo == null)
                {
                    myRepo = new RepositoryWrite<TRepo>(_dbContext);
                }
                return myRepo;
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            int result = await _dbContext.SaveChangesAsync();
            return result;
        }
    }
}
