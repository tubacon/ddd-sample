using ddd_sample.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddd_sample.Application.Interfaces
{
    public interface IDevice
    {
        Task<DeviceDto> CreateDeviceAsync(DeviceDto deviceDto);
        Task<DeviceDto> UpdateDeviceAsync(int id, DeviceDto deviceDto);
        Task<DeviceDto> GetDeviceByIdAsync(int id);
        Task<List<DeviceDto>> GetAllDevicesAsync();
        Task DeleteDeviceAsync(int id);

    }
}
