using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_EntityFramework
{
    [Table("Ürünler")]
    public class Product
    {
        public int Id { get; set; }

        [StringLength(15)]
        public string Name { get; set; }

        [DataType("decimal(18,4)")]
        public double Price { get; set; }

        [Column("Stok")]
        public int Stock { get; set; }

        [StringLength(50)] //Attribute
        public string? CategoryName { get; set; }

    }
}
