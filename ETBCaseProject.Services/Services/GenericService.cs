using ETBCaseProject.Business.Constants;
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
        /// <summary>
        /// Verilen entity'yi veritabanına kaydeder.UnitOfWork ile kayıt işlemi gerçekleştirir
        /// </summary>
        /// <param name="entity">Eklenmek istenen entity</param>
        /// <returns>eklenen entity verisi</returns>
        public async Task<T> AddAsync(T entity)  /// silinecek
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }
        /// <summary>
        /// Verilen entity'leri toplu olarak veritabanına kaydeder.UnitOfWork ile kayıt işlemi gerçekleştirir
        /// </summary>
        /// <param name="entities">Eklenmek istenen entity listesi</param>
        /// <returns>Eklenen entity listesi</returns>
        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }
        /// <summary>
        /// Veritabanında belirtilen şartları sağlayan bir entity olup olmadığını kontrol eder
        /// </summary>
        /// <param name="expression">Belirtilen şart</param>
        /// <returns>Böyle bir entity mevcutsa true,değilse false</returns>
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
        }
        /// <summary>
        /// Veritabanındaki,belirtilen tipte entitylerin tamamını getirir
        /// </summary>
        /// <returns>Verilen Entity'nin Listesi (List{T})</returns>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }
        /// <summary>
        /// Veritabanındaki,belirtilen tipte entitylerin tamamını,ChangeTracker'ın takibi olmadan getirir
        /// </summary>
        /// <returns>Verilen Entity'nin Listesi (List{T})</returns>
        public async Task<IEnumerable<T>> GetAllWithoutTrackingAsync()
        {
            return await _repository.GetAll().AsNoTracking().ToListAsync();
        }
        /// <summary>
        /// Verilen Id'nin ait olduğu entity'yi getirir
        /// </summary>
        /// <param name="id">Verileri istenen entity'nin id'si</param>
        /// <returns>Verilen id'ye sahip entity</returns>
        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
        /// <summary>
        /// Verilen entity veritabanında silindi olarak işaretler.SoftDelete işlemi uygular.UnitOfWork ile kayıt işlemi gerçekleştirir
        /// </summary>
        /// <param name="entity">Silinmek istenen entity</param>
        /// <returns></returns>
        public async Task RemoveAsync(T entity)
        {
            if (entity is not null)
            {
                _repository.Remove(entity);
                await _unitOfWork.CommitAsync();
            }
        }
        /// <summary>
        ///Verilen entity'leri veritabanında silindi olarak işaretler.SoftDelete işlemi uygular.UnitOfWork ile kayıt işlemi gerçekleştirir
        /// </summary>
        /// <param name="entities">Silinmek istenen entity listesi</param>
        /// <returns></returns>
        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            if (entities is not null && entities.Count()!=0)
            {
                _repository.RemoveRange(entities);
                await _unitOfWork.CommitAsync();
            }  
        }
        /// <summary>
        /// Verilen entity'yi veritabanında günceller.UnitOfWork ile kayıt işlemi gerçekleştirir
        /// </summary>
        /// <param name="entity">Güncellenmek istenen entity</param>
        /// <returns></returns>
        public async Task UpdateAsync(T entity)
        {
            if (entity is not null)
            {
                _repository.Update(entity);
                await _unitOfWork.CommitAsync();
            }
        }
        /// <summary>
        /// Filtre koşuluna uygun öğeleri seçmek için LINQ sorgusu oluşturur
        /// </summary>
        /// <param name="expression">Filtre koşulunu belirten lambda ifadesi</param>
        /// <returns>Filtrelenmiş öğelerin bulunduğu sorgu sonucu</returns>
        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
