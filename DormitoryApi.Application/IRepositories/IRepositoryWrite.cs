using DormitoryApi.Domain.Entities.Common;

namespace RestaurantFinalAPI.Application.IRepositories
{
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
