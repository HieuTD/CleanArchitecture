using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs.Brands;

namespace CleanArchitecture.Application.Interfaces.Services
{
    public  interface IBrandService
    {
        Task<IEnumerable<BrandViewModel>> GetAllBrandsAsync();
        Task<BrandViewModel> GetBrandByIdAsync(int id);
        Task AddBrandAsync(BrandCreateRequest request);
        Task UpdateBrandeAsync(int id, BrandCreateRequest request);
        Task DeleteBrandAsync(int id);
    }
}
