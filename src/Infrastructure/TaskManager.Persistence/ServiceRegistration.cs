﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskManager.Application.Interfaces.Repositories;
using TaskManager.Application.Interfaces.UnitOfWork;
using TaskManager.Persistence.Context;
using TaskManager.Persistence.Repositories;
using TaskManager.Persistence.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection, IConfiguration configuration = null)
        {

            serviceCollection.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(configuration?.GetConnectionString("SQLConnection"), sqlOption => sqlOption.UseNetTopologySuite()
            ));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
            serviceCollection.AddTransient<ICountryRepository, CountryRepository>();
            serviceCollection.AddTransient<ICityRepository, CityRepository>();
            serviceCollection.AddTransient<ITownRepository, TownRepository>();
            serviceCollection.AddTransient<IUserRepository, UserRepository>();

            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
