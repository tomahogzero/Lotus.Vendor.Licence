using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class modelCompany
    {
        public string Id { get; set; }
        public DateTime ModifiedAtUtc { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public string CompanyName { get; set; }
        public string CompanyId { get; set; }
        public int CompanyType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string CompanyGroupId { get; set; }
        public bool Enabled { get; set; }
        public string CompanyTax { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
    }
}