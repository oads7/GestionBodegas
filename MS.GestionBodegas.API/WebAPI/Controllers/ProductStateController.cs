using Application.Common.Interfaces;
using Application.UseCases.ProductStates;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/product-state")]
    [ApiController]
    public class ProductStateController : ControllerBase
    {
        private readonly ProductStatesQuery productStatesQuery;

        public ProductStateController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            productStatesQuery = new ProductStatesQuery(unitOfWork, mapper);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            try
            {
                return Ok(new ApiResponse<IEnumerable<ProductStateDTO>>(await productStatesQuery.GetAllStates()));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse<string>(ex.Message));
            }
        }
    }
}
