﻿using ETBCaseProject.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ETBCaseProject.Repository.Repositories
{
    /// <summary>
    /// Belirtilen tip için genel veritabanı işlemlerini yapan generic repository sınıfı
    /// </summary>
    /// <typeparam name="T">İşlem yapılacak entity tipi</typeparam>
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly EtbDbContext _context;

        public GenericRepository(EtbDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T Entity)
        {
            await _dbSet.AddAsync(Entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }
        /// <summary>
        /// Tüm Entity'leri Tracking pasif haldeyken çeken generic methodu.Büyük miktarda ve manipule edilmeyecek veri için performans sağlar 
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }
        public IQueryable<T> GetAllWithoutTracking()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(T Entity)
        {
            _dbSet.Remove(Entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(T Entity)
        {
            _dbSet.Update(Entity);
        }
        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
