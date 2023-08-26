
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FacebookClone.Infrastructure.Data;

namespace FacebookClone.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
           services.AddDbContext<FacebookCloneDbContext>(
            options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection", x => x.MigrationsAssembly("FacebookClone.Infrastructure")));

            return services;
    }
}
