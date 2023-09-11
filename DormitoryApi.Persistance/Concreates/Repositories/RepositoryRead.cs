using DormitoryApi.Domain.Entities.Common;
using DormitoryApi.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RestaurantFinalAPI.Application.DTOs.ExceptionDTOs;
using RestaurantFinalAPI.Application.Exceptions;
using RestaurantFinalAPI.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFinalAPI.Persistance.Concreates.Repositories
{
    public class RepositoryRead<T> : IRepositoryRead<T> where T : BaseEntity
    {
        private readonly DormitoryDbContext _dbContext;

        public RepositoryRead(DormitoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<T> Table => _dbContext.Set<T>();

        public IQueryable<T> GetAll()
        {
            var query = Table.AsQueryable();
            return query;
        }


        public async Task<T> GetByIdAsync(string id)
        {
                bool checkIdFormat = Guid.TryParse(id, out Guid guid); 
                if (checkIdFormat)
                {
                    var query = Table.AsQueryable();

                    return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
                }
                else
                {
                    throw new GenericCustomException<ExceptionDTO>($"Invalid Id Value: {id}");
                }
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
        {
            var query = Table.AsQueryable();
            
            return await query.FirstOrDefaultAsync(expression);
        }

        public IQueryable<T> GetWithFiltir(Expression<Func<T, bool>> expression)
        {
            var query = Table.Where(expression);

            return query;
        }
    }

    public class RepositoryWrite<T> : IRepositoryWrite<T> where T : BaseEntity
    {
        private readonly DormitoryDbContext _dbContext;

        public RepositoryWrite(DormitoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<T> Table => _dbContext.Set<T>();

        public async Task<bool> AddAsync(T data)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(data);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(ICollection<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T data)
        {
            EntityEntry<T> entityEntry = Table.Remove(data);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> Remove(string id)
        {
            bool checkIdFormat = Guid.TryParse(id, out Guid guid);
            if (checkIdFormat)
            {
                T data = await Table.FindAsync(Guid.Parse(id));
                return Remove(data);
            }
            else
                throw new GenericCustomException<ExceptionDTO>($"Invalid Id Value: {id}");

        }

        public bool RemoveRange(ICollection<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }
        //todo updateler async deyil
        public bool Update(T data)
        {
            EntityEntry<T> entityEntry = Table.Update(data);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool UpdateRange(ICollection<T> datas)
        {
            Table.UpdateRange(datas);
            return true;
        }

        //public async Task<int> SaveChangesAsync()
        //=> await _dbContext.SaveChangesAsync();

    }
}
