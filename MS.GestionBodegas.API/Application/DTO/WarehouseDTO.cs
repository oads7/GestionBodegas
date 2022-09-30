using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class WarehouseDTO
    {
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseDescription { get; set; }
        public string Capacity { get; set; }
    }
}
