using DormitoryApi.Domain.Entities.Common;
using System.Linq.Expressions;

namespace RestaurantFinalAPI.Application.IRepositories
{
    public interface IRepositoryRead<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();   
        IQueryable<T> GetWithFiltir(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(string id);
        //serte gore tek data
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression);
    }
}
