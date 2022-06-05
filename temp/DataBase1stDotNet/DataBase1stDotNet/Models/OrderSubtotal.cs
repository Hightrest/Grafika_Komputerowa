using System;
using System.Collections.Generic;

namespace DataBase1stDotNet.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
