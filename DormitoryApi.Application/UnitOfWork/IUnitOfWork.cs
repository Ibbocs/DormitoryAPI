using DormitoryApi.Domain.Entities.Common;
using RestaurantFinalAPI.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.UnitOfWork
{
    public interface IUnitOfWork<TRepo> : IDisposable where TRepo : BaseEntity
    {
        public IRepository<TRepo> Repository { get; }
        Task<int> SaveChangesAsync();
    }
}
