using System;
using System.Collections.Generic;

#nullable disable

namespace ABC.EFCore.Repository.Edmx
{
    public partial class Employer
    {
        public int EmployerId { get; set; }
        public string FederalEmployeeId { get; set; }
        public string EmployerName { get; set; }
        public string EmployerEmail { get; set; }
        public string EmployerPhone { get; set; }
        public string Extention { get; set; }
        public string Fax { get; set; }
        public string PayrolAddress { get; set; }
        public string City { get; set; }
        public string EmployerZipCode { get; set; }
        public string EmployerState { get; set; }
    }
}
