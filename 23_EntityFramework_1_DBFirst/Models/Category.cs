using System;
using System.Collections.Generic;

namespace _23_EntityFramework_1_DBFirst.Models;

public partial class Category
{
    //PK
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
