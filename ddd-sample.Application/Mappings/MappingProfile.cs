using AutoMapper;
using ddd_sample.Application.Dtos;
using ddd_sample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddd_sample.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DeviceDto, Device>().ReverseMap();
        }
    }
}
