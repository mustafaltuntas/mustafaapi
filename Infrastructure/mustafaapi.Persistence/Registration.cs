using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mustafaapi.Persistence.Context;

namespace mustafaapi.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
                opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
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