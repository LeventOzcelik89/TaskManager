//using Microsoft.EntityFrameworkCore;
//using TaskManager.Application.Interfaces.Repositories;
//using TaskManager.Domain.Common;

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TaskManager.Persistence.Repositories
//{
//    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
//    {
//        private readonly ApplicationDbContext _context;
//        public Repository(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        private DbSet<T> Table { get => _context.Set<T>(); }

//        public async Task<T> AddAsync(T entity)
//        {
//            await Table.AddAsync(entity);
//            await _context.SaveChangesAsync();
//            return entity;
//        }

//        public async Task<List<T>> GetAsync() => await Table.ToListAsync();
//        public async Task<T> GetByIdAsync(Guid id) => await Table.FindAsync(id);
//    }
//}
