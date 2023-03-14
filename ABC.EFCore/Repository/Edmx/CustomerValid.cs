using ABC.EFCore.Repository.Edmx;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ABC.EFCore.Repository.Edmx
{
    public class CustomerValid
    {
        public List<CertificateBusinessType> CertificateBusinessTypes { get; set; }
        public CertificateExemptionInstruction CertificateExemptionInstructions { get; set; }
        public List<CertificateIdentification> CertificateIdentifications { get; set; }
        public List<CertificateReasonExemption> CertificateReasonExemptions { get; set; }
        public CustomerPaperWork paperWork { get; set; }
        public AspNetUser AspNetUser { get; set; }
        [NotMapped]
        [Compare("PasswordHash")]
        public string ConfirmPassword { get; set; }

    }
    [MetadataType(typeof(CustomerValid))]
    public partial class Customer
    {
        public List<CertificateBusinessType> CertificateBusinessTypes { get; set; }
        public CertificateExemptionInstruction CertificateExemptionInstructions { get; set; }
        public List<CertificateIdentification> CertificateIdentifications { get; set; }
        public List<CertificateReasonExemption> CertificateReasonExemptions { get; set; }
        public CustomerPaperWork paperWork { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [NotMapped]
        public AspNetUser AspNetUser { get; set; }
    



    }
}
