using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.EFCore.Repository.Edmx
{
    public class CartDetail
    {
        public int cartID { get; set; }
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string retail { get; set; }
        public string total { get; set; }
        public int Quantity { get; set; }
        public int Count { get; set; }
        public Product ProductObj { get; set; }




        //TotalPricews
        //    GrossBill
        //    productid
        //    productCode
    }
}
