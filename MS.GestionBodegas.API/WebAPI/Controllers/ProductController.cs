using Application.Common.Interfaces;
using Application.DTO;
using Application.UseCases.Products;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductsQuery productsQuery;
        private readonly ProductsCommand productsCommand;

        public ProductController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            productsQuery = new ProductsQuery(unitOfWork, mapper);
            productsCommand = new ProductsCommand(unitOfWork, mapper);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct([FromQuery] int warehouseId)
        {
            try
            {
                return Ok(new ApiResponse<IEnumerable<ProductDTO>>(await productsQuery.GetAllProducts(warehouseId)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse<string>(ex.Message));
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct(ProductDTO product)
        {
            try
            {
                await productsCommand.SaveProduct(product);
                return Ok(new ApiResponse<bool>(true));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse<string>(ex.Message));
            }
        }
    }
}
