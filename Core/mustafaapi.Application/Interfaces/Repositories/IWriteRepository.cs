using System;
using mustafaapi.Domain.Common;
namespace mustafaapi.application.Interfaces.Repositories
{
	public interface IWriteRepository<T> where T :  class, IEntityBase, new()
	{
		Task<int> AddAsync(T entity);

		Task<IList<int>> AddRangeAsync(IList<T> entities);

		Task<T> UpdateAsync(T entity);

		Task HardDeleteAsync(T entity);

        Task SoftDeleteAsync(T entity);
    }
}

