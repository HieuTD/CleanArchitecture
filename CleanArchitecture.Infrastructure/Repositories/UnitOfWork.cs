using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces.Repositories;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IBlogRepository BlogRepository { get; }
        public IBrandRepository BrandRepository { get; }

        public UnitOfWork(ApplicationDbContext dbContext, IBlogRepository blogRepository, IBrandRepository brandRepository)
        {
            _dbContext = dbContext;
            BlogRepository = blogRepository;
            BrandRepository = brandRepository;
        }


        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
