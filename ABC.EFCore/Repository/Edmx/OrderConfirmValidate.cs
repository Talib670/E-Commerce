using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.EFCore.Repository.Edmx
{
    public class OrderConfirmValidate
    {
        [NotMapped]
        public virtual CustomerAddress customeraddress { get; set; }
    }
    [MetadataType(typeof(OrderConfirmValidate))]
    public partial class Order
    { 
        [NotMapped]
    public virtual CustomerAddress customeraddress { get; set; }

    }
}
