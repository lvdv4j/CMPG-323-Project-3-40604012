using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EcoPower_Logistics.Data.Models
{
    public partial class OrderDetail
    {
        [DisplayName("Order Details ID")]
        public int OrderDetailsId { get; set; }
        [DisplayName("Order ID")]
        public int OrderId { get; set; }
        [DisplayName("Product ID")]
        public int ProductId { get; set; }
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
        [DisplayName("Discount")]
        public int? Discount { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
