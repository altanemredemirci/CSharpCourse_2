using System;
using System.Collections.Generic;

namespace _23_EntityFramework_1_DBFirst.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
