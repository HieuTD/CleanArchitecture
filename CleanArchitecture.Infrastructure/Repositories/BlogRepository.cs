using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class BlogRepository : GenericRepository<Blog> ,IBlogRepository
    {   
        //private readonly ApplicationDbContext _context;
        public BlogRepository(ApplicationDbContext context) :base(context)
        {
        }

        public async Task<IEnumerable<Blog>> GetAllBlogsWithUserInfo()
        {
            return await _dbContext.Blogs
                .Include(b => b.BlogImages)
                .Include(b => b.AppUser)
                .ToListAsync();
        }

        //public async Task AddBlogAsync(Blog blog)
        //{
        //    _context.Blogs.Add(blog);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteBlogAsync(Blog blog)
        //{
        //    _context.Blogs.Remove(blog);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<Blog>> GetAllBlogsAsync()
        //{
        //    return await _context.Blogs
        //        .Include(b => b.BlogImages)
        //        .Include(b => b.AppUser)
        //        .ToListAsync();
        //}

        //public async Task<Blog> GetBlogByIdAsync(int id)
        //{
        //    return await _context.Blogs
        //        .Include(b => b.BlogImages)
        //        .FirstOrDefaultAsync(b => b.Id == id);
        //}

        //public async Task UpdateBlogAsync(Blog blog)
        //{
        //    _context.Blogs.Update(blog);
        //    await _context.SaveChangesAsync();
        //}
    }
}
