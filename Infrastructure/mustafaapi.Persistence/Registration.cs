using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mustafaapi.application.Interfaces.Repositories;
using mustafaapi.application.Interfaces.UnitOfWorks;
using mustafaapi.Persistence.Context;
using mustafaapi.Persistence.Repositories;
using mustafaapi.Persistence.UnitOfWorks;

namespace mustafaapi.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
                opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));

            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}


/*
namespace mustafaapi.Persistence
{
	public static class Registration
	{
		public static void AddPersistence(this IServiceCollection services,IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(opt =>
			opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
		}
	}
}

*/