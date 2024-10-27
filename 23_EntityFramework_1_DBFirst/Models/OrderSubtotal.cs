using System;
using System.Collections.Generic;

namespace _23_EntityFramework_1_DBFirst.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
