using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs.Brands;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Application.Interfaces.Services;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Services
{
    public class BrandService : IBrandService
    {
        //private readonly IBrandRepository _brandRepository;
        public readonly IUnitOfWork _unitOfWork;

        public BrandService(IBrandRepository brandRepository, IUnitOfWork unitOfWork)
        {
            //_brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddBrandAsync(BrandCreateRequest request)
        {
            Brand brand = new Brand();
            brand.Name = request.BrandName;
            brand.CreatedAt = DateTime.Now;
            await _unitOfWork.BrandRepository.AddAsync(brand);
            _unitOfWork.Save();
        }

        public async Task DeleteBrandAsync(int id)
        {
            var brand = await _unitOfWork.BrandRepository.GetByIdAsync(id);

            if (brand == null)
            {
                throw new Exception("Brand doesn't exist");
            }

            _unitOfWork.BrandRepository.DeleteAsync(brand);
        }

        public async Task<IEnumerable<BrandViewModel>> GetAllBrandsAsync()
        {
            var brands = await _unitOfWork.BrandRepository.GetAllAsync();

            return brands.Select(b => new BrandViewModel
            {
                Id = b.Id,
                BrandName = b.Name
            });
        }

        public async Task<BrandViewModel> GetBrandByIdAsync(int id)
        {
            var brand = await _unitOfWork.BrandRepository.GetByIdAsync(id);
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
            var brand = await _unitOfWork.BrandRepository.GetByIdAsync(id);

            if (brand == null)
            {
                throw new Exception("Brand doesn't exist");
            }

            brand.UpdatedAt = DateTime.Now;
            brand.Name = request.BrandName;

            _unitOfWork.BrandRepository.UpdateAsync(brand);
            _unitOfWork.Save();
        }
    }
}
