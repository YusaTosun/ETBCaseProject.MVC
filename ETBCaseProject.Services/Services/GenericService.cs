﻿using AutoMapper;
using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Repositories;
using ETBCaseProject.Core.Services;
using ETBCaseProject.Core.UnitOfWorks;
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

        public async Task<T> AddAsync(T entity)
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

        public async Task RemoveAsync(T entity)
        {
            _repository.Remove(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
                _repository.Update(entity);
                await _unitOfWork.CommitAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
