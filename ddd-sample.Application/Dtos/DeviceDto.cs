﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ddd_sample.Application.Dtos
{
    public class DeviceDto
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }

        public DeviceDto() { } // without parameter

        public DeviceDto(int id, string deviceName)
        {
            Id = id;
            DeviceName = deviceName;
        }
    }
}
