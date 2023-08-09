﻿using ETBCaseProject.Core.UnitOfWorks;

namespace ETBCaseProject.Repository.UnitOfWorks
{
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
