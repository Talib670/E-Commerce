using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.EFCore.Repository.Edmx
{
   public class CustomerValidation
    {
        [NotMapped]
        public CustomerClassification CustomerClassification { get; set; }
        [NotMapped]
        public CustomerBillingInfo CustomerBillingInfo { get; set; }
    }
    [MetadataType(typeof(CustomerValidation))]
    public partial class CustomerInformation
    {
        [NotMapped]
        public CustomerClassification CustomerClassification { get; set; }
        [NotMapped]
        public CustomerBillingInfo CustomerBillingInfo { get; set; }
    }
    
}
