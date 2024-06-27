using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddd_sample.Domain.Entities
{
    public class Device
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}

