using DormitoryApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFinalAPI.Application.IRepositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }

    public interface IRepositoryRead<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();   
        IQueryable<T> GetWithFiltir(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(string id);
        //serte gore tek data
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression);
    }

    public interface IRepositoryWrite<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T data);
        Task<bool> AddRangeAsync(ICollection<T> datas);

        bool Remove(T data);
        Task<bool> Remove(string id); 
        bool RemoveRange(ICollection<T> datas);

        bool Update(T data);
        bool UpdateRange(ICollection<T> datas);

        //Task<int> SaveChangesAsync();

    }
}
