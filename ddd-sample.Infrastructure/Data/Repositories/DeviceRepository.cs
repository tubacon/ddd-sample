using ddd_sample.Domain.Entities;
using ddd_sample.Domain.Repositories;
using ddd_sample.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ddd_sample.Infrastructure.Data.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly ddd_sampleDbContext _context; 

        public DeviceRepository(ddd_sampleDbContext context)
        {
            _context = context;
        }


        public async void CreateDeviceAsync(Device device)
        {
            _context.Devices.Add(device);
            await _context.SaveChangesAsync();
        }

        public async void DeleteDeviceAsync(int id)
        {
            var device = _context.Devices.Find(id);
            if (device != null)
            {
                _context.Devices.Remove(device);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Device>> GetAllDevicesAsync()
        {
            return await _context.Devices.ToListAsync();
        }

        public async Task<Device> GetDeviceByIdAsync(int id)
        {
            return _context.Devices.Find(id);
        }

        public async Task UpdateDeviceAsync(int id, Device device)
        {
            _context.Devices.Update(device);
            _context.SaveChanges();
        }
    }
}
