﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETBCaseProject.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T Entity);
        //Task AddRangeAsync(IEnumerable<T> entities); //todo: bunlara sonra bak
        void Update(T Entity);
        void Remove(T Entity);
        //void RemoveRange(IEnumerable<T> entities);

    }
}
