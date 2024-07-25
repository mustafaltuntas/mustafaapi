using System;
using mustafaapi.application.Interfaces.Repositories;

namespace mustafaapi.application.Interfaces.UnitOfWorks
{
	public interface IUnitOfWork : IAsyncDisposable
	{
		IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new();

        IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new();

		Task<int> SaveAsync();
		int Save();
    }

    public interface IEntityBase
    {
    }
}

