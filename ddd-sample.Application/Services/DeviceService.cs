using ddd_sample.Application.Dtos;
using ddd_sample.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddd_sample.Application.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly List<DeviceDto> _devices = new List<DeviceDto>();

        public Task<DeviceDto> CreateDeviceAsync(DeviceDto deviceDto)
        {
            var device = new DeviceDto();
            device.Id = _devices.Count + 1;
            device.DeviceName = deviceDto.DeviceName;
            device.DateAdded = DateTime.Now;
            device.DateUpdated = DateTime.Now;
            _devices.Add(device);
            return Task.FromResult(device);
        }

        public async Task DeleteDeviceAsync(int id)
        {
            var device = _devices.Find(x => x.Id == id);
            if (device != null)
            {
                _devices.Remove(device);
            }
            await Task.CompletedTask;
        }

        public async Task<List<DeviceDto>> GetAllDevicesAsync()
        {
            return await Task.FromResult(_devices);
        }

        public async Task<DeviceDto> GetDeviceByIdAsync(int id)
        {
            var device = _devices.Find(x => x.Id == id);
            return await Task.FromResult(device);
        }

        public Task<DeviceDto> UpdateDeviceAsync(int id, DeviceDto deviceDto)
        {
            var device = _devices.Find(x => x.Id == id);
            if (device != null)
            {
                device.DeviceName = deviceDto.DeviceName;
                device.DateUpdated = DateTime.Now;
            }
            return Task.FromResult(device);
        } 
    }
}
