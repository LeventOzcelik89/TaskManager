using Microsoft.EntityFrameworkCore.Storage;
using TaskManager.Application.Interfaces.Repositories;
using TaskManager.Application.Interfaces.UnitOfWork;
using TaskManager.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IProductRepository ProductRepository { get; }

        public IUserRepository UserRepository { get; }

        public ICountryRepository CountryRepository { get; }

        public ICityRepository CityRepository { get; }

        public ITownRepository TownRepository { get; }


        public UnitOfWork(ApplicationDbContext context, IProductRepository productRepository)
        {
            _context = context;
            ProductRepository = productRepository;
        }
        public async Task<IDbContextTransaction> BeginTransactionAsync() => await _context.Database.BeginTransactionAsync();
        public async ValueTask DisposeAsync() { }
    }
}
