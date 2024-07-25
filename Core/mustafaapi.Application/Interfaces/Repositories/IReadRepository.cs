using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;
using mustafaapi.application.Interfaces.UnitOfWorks;

namespace mustafaapi.application.Interfaces.Repositories
{
	public interface IReadRepository<T> where T : class, IEntityBase, new()
	{
		Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
			Func<IIncludableQueryable<T,object>>? include = null,
			Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
			bool enableTracking = false);


        Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false, int currentPage = 1, int pageSize = 3);

        Task<IList<T>> GetAsync(Expression<Func<T, bool>>? predicate,
         Func<IIncludableQueryable<T, object>>? include = null,
         bool enableTracking = false);


        IQueryable<T> Find(Expression<Func<T,bool>> predicate);

        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
    }



}
