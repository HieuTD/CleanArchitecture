using CleanArchitecture.Application.DTOs.Brands;
using CleanArchitecture.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<ActionResult<BrandViewModel>> GetAllBrandsAsync()
        {
            var brands = await _brandService.GetAllBrandsAsync();
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BrandViewModel>> GetBrandByIdAsync(int id)
        {
            var brand = await _brandService.GetBrandByIdAsync(id);
            return Ok(brand);
        }

        [HttpPost]
        public async Task<IActionResult> AddBrandAsync([FromForm] BrandCreateRequest request)
        {
            await _brandService.AddBrandAsync(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrandAsync(int id, [FromForm] BrandCreateRequest request)
        {
            await _brandService.UpdateBrandeAsync(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrandAsync(int id)
        {
            await _brandService.DeleteBrandAsync(id);
            return Ok();
        }
    }
}
