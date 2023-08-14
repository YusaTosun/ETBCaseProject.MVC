using ETBCaseProject.Core.UnitOfWorks;

namespace ETBCaseProject.Repository.UnitOfWorks
{
    /// <summary>
    /// Veritabanı işlemlerini yönetmek için UnitOfWork Tasarım Deseni uygulayan sınıf
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EtbDbContext _context;

        public UnitOfWork(EtbDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
