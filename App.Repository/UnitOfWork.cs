using App.Data.Models;
using App.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _DbContext;

        public StudentRepository StudentRepository { get; }

        public UnitOfWork(AppDbContext context)
        {
            _DbContext = context;
            StudentRepository = new StudentRepository(_DbContext);
        }
        public async Task Commit()
        {
            await _DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _DbContext.Dispose();
        }
    }
}
