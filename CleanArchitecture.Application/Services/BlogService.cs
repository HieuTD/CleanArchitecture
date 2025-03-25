using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs.Blogs;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Application.Interfaces.Services;
using CleanArchitecture.Domain.Entities;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;


namespace CleanArchitecture.Application.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IDatabase _cache;
        private readonly int _cacheExpirationMinutes;

        public BlogService(IBlogRepository blogRepository, IConfiguration configuration)
        {
            _blogRepository = blogRepository;
            var redis = ConnectionMultiplexer.Connect(configuration["Redis:ConnectionString"]);
            _cache = redis.GetDatabase();
            _cacheExpirationMinutes = int.Parse(configuration["Redis:CacheExpirationMinutes"]);
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
            if (blog == null)
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
            string cacheKey = "blog_list";
            string cachedData = await _cache.StringGetAsync(cacheKey);

            //Kiểm tra redis có sẵn dữ liệu blog không (với key = "blog_list") nếu có thì lấy từ redis, nếu không thì lấy từ repo
            if (!String.IsNullOrEmpty(cachedData))
            {
                return JsonSerializer.Deserialize<List<BlogViewModel>>(cachedData);
            }
            var blogsRepo = await _blogRepository.GetAllBlogsAsync();

            var blogs = blogsRepo.Select(b => new BlogViewModel
            {
                Id = b.Id,
                Description = b.Description,
                UserName = b.AppUser.FirstName,
                CreatedAt = DateTime.Now
            });

            //Thêm dữ liệu vào redis (với key = "blog_list") | set thời gian tự động xóa cache sau 10' (_cacheExpirationMinutes)
            await _cache.StringSetAsync(cacheKey, JsonSerializer.Serialize(blogs), TimeSpan.FromMinutes(_cacheExpirationMinutes));

            return blogs;
        }

        public async Task UpdateBlogAsync(int id, BlogCreateRequest request)
        {
            var blog = await _blogRepository.GetBlogByIdAsync(id);

            blog.Description = request.Description;
            blog.Title = request.Title;
            blog.UpdatedAt = DateTime.Now;

            await _blogRepository.UpdateBlogAsync(blog);
        }
    }
}
