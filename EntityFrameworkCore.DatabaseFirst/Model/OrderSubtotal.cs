﻿namespace Jarai.CSharp.EntityFrameworkCore.DatabaseFirst.Model;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
