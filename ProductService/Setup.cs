using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductService.Data.Context;
using ProductService.Data.Repositories;
using ProductService.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService
{
    public static class Setup
    {
        public static void ConfigureDbContext(this IServiceCollection services)
        {
            services.AddScoped<DataContext, DataContext>();
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {            
            services.AddTransient<IUserRepository, UserRepository>();
        }      

        public static void ConfigureMigrations(this IApplicationBuilder app, DataContext context)
        {
            context.Database.Migrate();
        }        

    }
}
