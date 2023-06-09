using Microsoft.AspNetCore.Mvc;
using Pets.Services.Dto;
using Pets.Services;

namespace PetSalon.Controllers
{
    public class ServicesController
    {
        [ApiController]
        [Route("[controller]")]
        public class ServiceController : ControllerBase
        {
            private readonly IServicesService _service;

            public ServiceController(IServicesService service)
            {
                _service = service;
            }

            public IServicesService Get_service()
            {
                return _service;
            }

            [HttpGet()]
            public Task<List<ServiceDto>> Get(IServicesService _service)
            {
                return _service.GetAll();
            }

            [HttpPost()]
            public Task<long> Create([FromBody] ServiceCreateDto dto)
            {
                return _service.Create(dto);
            }
        }
    }
}
