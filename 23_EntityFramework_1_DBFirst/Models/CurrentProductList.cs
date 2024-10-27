using System;
using System.Collections.Generic;

namespace _23_EntityFramework_1_DBFirst.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
