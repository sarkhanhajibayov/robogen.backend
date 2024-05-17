
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using robogen.backend.Application.Repositories;
using robogen.backend.Domain.Entities;
using robogen.backend.Persistence.DTOs;
using robogen.backend.Persistence.FilterModels;

namespace robogen.backend.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;


        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IMapper mapper)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        [HttpGet,Route("get-all")]
        public IActionResult GetAllProducts()
        {
            try
            {
                // Retrieve all products from the repository
                var products = _productReadRepository.GetAll().Include(p => p.Theme).Include(p => p.Serie).Include(p => p.AgeGroup).Include(p=>p.Gender);
                ;
                ;

                // Check if any products were found
                if (products == null || !products.Any())
                {
                    return NotFound("No products found.");
                }

                var productDtos = _mapper.Map<IEnumerable<ProductDTO>>(products);

                // Return the mapped DTOs as a JSON response
                return Ok(productDtos);
            }
            catch (Exception ex)
            {
                // Handle any exceptions and return a 500 Internal Server Error response
                return StatusCode(500, $"An error occurred while retrieving products: {ex.Message}");
            }
        }
        [HttpPost, Route("get-products")]

        public List<ProductDTO> GetAll( ProductFilterVM model)
        {

            var query = _productReadRepository.AllQuery
                .Where
                    (
                        x =>
                        (model.SerieId == null ? true : x.SerieId == model.SerieId) &&
                        (model.ThemeId == null ? true : x.ThemeId == model.ThemeId) &&
                        (model.GenderId == null ? true : x.GenderId == model.GenderId) &&
                        (model.AgeGroupId == null ? true : x.AgeGroupId == model.AgeGroupId) &&
                        (string.IsNullOrEmpty(model.Name) ? true : x.Name.ToLower().Contains(model.Name.ToLower()))
                 )
                 .OrderBy(x => x.Name);
                var productDtos =  query
                .ProjectTo<ProductDTO>(_mapper.ConfigurationProvider)
                .ToList();

            return productDtos;
        }
        [HttpPost, Route("add-product")]
        public async Task<IActionResult> AddProduct(ProductWriteDTO productDto)
        {
            try
            {
                var product = _mapper.Map<Product>(productDto);
                await _productWriteRepository.AddAsync(product);
                await _productWriteRepository.SaveAsync();
                return Ok(new { message = "Product added successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(new { message = "Error happened" });
            }
        }

        [HttpDelete, Route("delete-product/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                // Call the RemoveAsync method from your repository
                var isDeleted = await _productWriteRepository.RemoveAsync(id);

                // Save changes to the database
                await _productWriteRepository.SaveAsync();

                if (isDeleted)
                {
                    // Product was successfully deleted
                    return Ok(new { message = "Product deleted successfully" });
                }
                else
                {
                    // Product with the provided id was not found
                    return NotFound(new { message = "Product not found" });
                }
            }
            catch (Exception ex)
            {
                // Log the exception

                // Return error response
                return StatusCode(500, new { message = "Failed to delete product" });
            }
        }
    }
    }

