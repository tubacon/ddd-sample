using ddd_sample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddd_sample.Domain.Repositories
{
    public interface IDeviceRepository
    {
        void CreateDeviceAsync(Device device);
        Task UpdateDeviceAsync(int id, Device device);
        void DeleteDeviceAsync(int id);
        Task<Device> GetDeviceByIdAsync(int id);
        Task<IEnumerable<Device>> GetAllDevicesAsync();

    }
}
