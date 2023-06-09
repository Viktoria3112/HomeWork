using Microsoft.AspNetCore.Mvc;
using Pets.Services;
using Pets.Services.Dto;

namespace PetSalon.Controllers
{
  
        [ApiController]
        [Route("[controller]")]
        public class AnimalsController : ControllerBase
        {
            private readonly IPetsService _service;

            public AnimalsController(IPetsService service)
            {
                _service = service;
            }

            public IPetsService Get_service()
            {
                return _service;
            }

            [HttpGet()]
            public Task<List<AnimalDto>> Get(IPetsService _service)
            {
                return _service.GetAll();
            }

            [HttpPost()]
            public Task<long> Create([FromBody] AnimalCreateDto dto)
            {
                return _service.Create(dto);
            }
        }
    }

