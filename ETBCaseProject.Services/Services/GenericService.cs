﻿using ETBCaseProject.Business.Constants;
using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Repositories;
using ETBCaseProject.Core.Services;
using ETBCaseProject.Core.UnitOfWorks;
using ETBCaseProject.Core.Utilities.Results;
using ETBCaseProject.Core.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ETBCaseProject.Services.Services
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<T> _repository;

        public GenericService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<T> AddAsync(T entity)  /// silinecek
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }
        public async Task<IEnumerable<T>> GetAllWithoutTrackingAsync()
        {
            return await _repository.GetAll().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IResult> RemoveAsync(T entity)
        {
            if (entity is not null)
            {
                _repository.Remove(entity);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(Messages.DeleteSuccess);
            }
            return new ErrorResult(Messages.NullData);
        }

        public async Task<IResult> RemoveRangeAsync(IEnumerable<T> entities)
        {
            if (entities is not null && entities.Count() != 0)
            {
                _repository.RemoveRange(entities);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(Messages.DeleteSuccess);
            }
            return new ErrorResult(Messages.NullData);

        }

        public async Task UpdateAsync(T entity)
        {
            if (entity is not null)
            {
                _repository.Update(entity);
                await _unitOfWork.CommitAsync();
            }
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
