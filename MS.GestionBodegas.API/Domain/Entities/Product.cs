using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

    [Table("Products")]
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductId", TypeName = "int")]
        public int ProductId { get; set; }

        [Column("ProductName", TypeName = "varchar(32)")]
        public string ProductName { get; set; }

        [Column("ProductDescription", TypeName = "varchar(128)")]
        public string ProductDescription { get; set; }

        [Column("WarehouseId", TypeName = "int")]
        public int WarehouseId { get; set; }

        [Column("State", TypeName = "varchar(16)")]
        public string State { get; set; }

        [Column("ManufacturingDate", TypeName = "date")]
        public DateTime ManufacturingDate { get; set; }

        [Column("ExpirationDate", TypeName = "date")]
        public DateTime ExpirationDate { get; set; }

        [Column("EntryDate", TypeName = "date")]
        public DateTime EntryDate { get; set; }

        [Column("ReleaseDate", TypeName = "date")]
        public DateTime ReleaseDate { get; set; }

        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }
    }
}
