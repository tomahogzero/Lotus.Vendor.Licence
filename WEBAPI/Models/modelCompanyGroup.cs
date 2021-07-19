using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class modelCompanyGroup
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedAtUtc { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public object LicenseToken { get; set; }
    }

    public class modelCompanyGroupUpdateToken
    {
        public string Name { get; set; }
        public object LicenseToken { get; set; }
    }
}