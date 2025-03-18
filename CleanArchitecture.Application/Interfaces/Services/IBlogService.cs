using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs.Blogs;

namespace CleanArchitecture.Application.Interfaces.Services
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogViewModel>> GetAllBlogsAsync();
        Task AddBlogAsync(BlogCreateRequest request);
        Task UpdateBlogAsync(int id, BlogCreateRequest request);
        Task DeleteBlogAsync(int id);
    }
}
