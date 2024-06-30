using AutoMapper;
using ddd_sample.Application.Dtos;
using ddd_sample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ddd_sample.API.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IDeviceService _deviceService;
        private readonly IMapper _mapper;

        public IActionResult Index()
        {
            var data = _deviceService.GetAllDevicesAsync();
            return View(data);
        }

        private static List<DeviceDto> devices = new List<DeviceDto>
        {
            new DeviceDto(1, "Device 1"),
            new DeviceDto(2, "Device 2")
        };


        public DeviceController(IDeviceService deviceService, IMapper mapper)
        {
            _deviceService = deviceService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceDto>>> GetDevices()
        {
            var devices =  await _deviceService.GetAllDevicesAsync();
            return Ok(devices);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceDto>> GetDevice(int id)
        {
            var device = await _deviceService.GetDeviceByIdAsync(id);
            if (device == null)
            {
                return NotFound();
            }
            return Ok(device);
        }

        [HttpPost]
        public async Task<IActionResult> AddDevice(DeviceDto deviceDto)
        {
            await _deviceService.CreateDeviceAsync(deviceDto);
            return CreatedAtAction(nameof(AddDevice), new { id = deviceDto.Id }, deviceDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDevice(int id, DeviceDto deviceDto)
        {
            if (id != deviceDto.Id)
            {
                return BadRequest();
            }

            await _deviceService.UpdateDeviceAsync(id, deviceDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDevice(int id)
        {
            await _deviceService.DeleteDeviceAsync(id);
            return NoContent();
        }
    }
}
