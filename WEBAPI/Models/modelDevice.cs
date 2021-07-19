using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class modelDevice
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SerialNo { get; set; }
        public string CompanyGroupId { get; set; }
        public DateTime ModifiedAtUtc { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public string SerialNoHash { get; set; }
    }

    public class modelDeviceUpdate
    {
        public string Name { get; set; }
        public string SerialNo { get; set; }
        public string SerialNoHash { get; set; }
    }
}