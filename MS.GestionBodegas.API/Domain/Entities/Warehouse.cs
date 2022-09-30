using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Warehouses")]
    public class Warehouse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("WarehouseId", TypeName = "int")]
        public int WarehouseId { get; set; }

        [Column("WarehouseName", TypeName = "varchar(32)")]
        public string WarehouseName { get; set; }

        [Column("WarehouseDescription", TypeName = "varchar(128)")]
        public string WarehouseDescription { get; set; }

        [Column("Capacity", TypeName = "varchar(32)")]
        public string Capacity { get; set; }

        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }
    }
}
