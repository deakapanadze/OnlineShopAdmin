using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Core.Application.Interfaces.Repositories;
using Infrastructure.Database.Implementations;

namespace Infrastructure.Database
{
    public static class ServiceExtensions
    {
        public static void AddDbLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StudentsDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("StudentDbConnection")));
            services.AddScoped<IStudentRepository, StudentRepository>();
        

        }
    }
}
