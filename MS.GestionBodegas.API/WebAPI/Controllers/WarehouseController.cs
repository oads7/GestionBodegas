using Application.Common.Interfaces;
using Application.DTO;
using Application.UseCases.Warehouses;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/warehouse")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly WarehousesQuery warehousesQuery;
        public WarehouseController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            warehousesQuery = new WarehousesQuery(unitOfWork, mapper);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWarehouses()
        {
            try
            {
                return Ok(new ApiResponse<IEnumerable<WarehouseDTO>>(await warehousesQuery.GetAllWarehouses()));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse<string>(ex.Message));
            }
        }
    }
}
