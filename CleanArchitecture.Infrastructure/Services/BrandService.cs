using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs.Brands;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Application.Interfaces.Services;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Infrastructure.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task AddBrandAsync(BrandCreateRequest request)
        {
            Brand brand = new Brand();
            brand.Name = request.BrandName;
            brand.CreatedAt = DateTime.Now;
            await _brandRepository.AddBrandAsync(brand);
        }

        public async Task DeleteBrandAsync(int id)
        {
            var brand = await _brandRepository.GetBrandByIdAsync(id);

            if (brand == null)
            {
                throw new Exception("Brand doesn't exist");
            }

            await _brandRepository.DeleteBrandAsync(brand);
        }

        public async Task<IEnumerable<BrandViewModel>> GetAllBrandsAsync()
        {
            var brands = await _brandRepository.GetAllBrandsAsync();

            return brands.Select(b => new BrandViewModel
            {
                Id = b.Id,
                BrandName = b.Name
            });
        }

        public async Task<BrandViewModel> GetBrandByIdAsync(int id)
        {
            var brand = await _brandRepository.GetBrandByIdAsync(id);
            if (brand == null)
            {
                throw new Exception("Brand doesn't exist");
            }
            return new BrandViewModel
            {
                Id = brand.Id,
                BrandName = brand.Name
            };
        }

        public async Task UpdateBrandeAsync(int id, BrandCreateRequest request)
        {
            var brand = await _brandRepository.GetBrandByIdAsync(id);

            if (brand == null)
            {
                throw new Exception("Brand doesn't exist");
            }

            brand.UpdatedAt = DateTime.Now;
            brand.Name = request.BrandName;

            await _brandRepository.UpdateBrandAsync(brand);
        }
    }
}
