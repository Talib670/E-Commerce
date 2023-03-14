using System;
using System.Collections.Generic;

#nullable disable

namespace ABC.EFCore.Repository.Edmx
{
    public partial class CartItme
    {
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public int? UserId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public int? SalePrice { get; set; }
        public int? Qty { get; set; }
        public int? TotalPrice { get; set; }
        public int? GrossAmount { get; set; }
        public int? NoOfItems { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? Date { get; set; }
        public bool? Delivery { get; set; }
        public bool? OrderStatus { get; set; }
    }
}
