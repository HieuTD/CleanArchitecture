using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs.Blogs;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Application.Interfaces.Services;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Infrastructure.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogService(IBlogRepository blogRepository) 
        {
            _blogRepository = blogRepository;
        }
        public async Task AddBlogAsync(BlogCreateRequest request)
        {
            Blog blog = new Blog();
            blog.Title = request.Title;
            blog.Description = request.Description;
            blog.UserId = request.UserId;
            blog.CreatedAt = DateTime.Now;
            if (request.files != null)
            {
                blog.BlogImages = new List<BlogImage>()
                {
                    new BlogImage
                    {
                        CreatedAt = DateTime.Now,
                        //Name = await this.SaveFile(request.files),
                    }
                };
            }

            await _blogRepository.AddBlogAsync(blog);
        }

        public async Task DeleteBlogAsync(int id)
        {
            var blog = await _blogRepository.GetBlogByIdAsync(id);
            if(blog == null)
            {
                throw new Exception("Blog does not exist");
            }
            else
            {
                await _blogRepository.DeleteBlogAsync(blog);
            }
        }

        public async Task<IEnumerable<BlogViewModel>> GetAllBlogsAsync()
        {
            var blogs = await _blogRepository.GetAllBlogsAsync();
            return blogs.Select(b => new BlogViewModel
            {
                Id = b.Id,
                Description = b.Description,
                UserName = b.AppUser.FirstName,
                CreatedAt = DateTime.Now
            });
        }

        public async Task UpdateBlogAsync(int id, BlogCreateRequest request)
        {
            var blog =  await _blogRepository.GetBlogByIdAsync(id);

            blog.Description = request.Description;
            blog.Title = request.Title;
            blog.UpdatedAt = DateTime.Now;

            await _blogRepository.UpdateBlogAsync(blog);
        }
    }
}
