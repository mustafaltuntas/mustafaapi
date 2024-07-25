using System;
using mustafaapi.application.Interfaces.Repositories;
using mustafaapi.application.Interfaces.UnitOfWorks;
using mustafaapi.Persistence.Context;
using mustafaapi.Persistence.Repositories;

namespace mustafaapi.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        public int Save() => AppDbContext.SaveChanges();


        public async Task<int> SaveAsync() => await dbContext.SaveChangesAsync();


        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);


        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);
       
    }
}

