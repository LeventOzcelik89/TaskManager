using Microsoft.EntityFrameworkCore.Storage;
using OnionArcExample.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        //IDbContextTransaction : EntityFrameworkCore kütüphanesine ihtiyaç vardır.
        Task<IDbContextTransaction> BeginTransactionAsync();
        public IProductRepository ProductRepository { get; }

        public IUserRepository UserRepository { get; }
        public ICountryRepository CountryRepository { get; }
        public ICityRepository CityRepository { get; }
        public ITownRepository TownRepository { get; }
    }
}
