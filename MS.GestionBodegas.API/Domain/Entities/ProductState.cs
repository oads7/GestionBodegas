using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("ProductStates")]
    public class ProductState
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductStateId", TypeName = "int")]
        public int ProductStateId { get; set; }

        [Column("State", TypeName = "varchar(16)")]
        public string State { get; set; }
    }
}
