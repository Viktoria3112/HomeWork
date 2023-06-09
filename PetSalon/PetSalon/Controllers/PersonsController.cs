using Microsoft.AspNetCore.Mvc;
using Pets.Services;
using Pets.Services.Dto;

namespace PetSalon.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _service;

        public PersonsController(IPersonService service)
        {
            _service = service;
        }

        public IPersonService Get_service()
        {
            return _service;
        }

        [HttpGet()]
        public Task<List<PersonDto>> Get(IPersonService _service)
        {
            return _service.GetAll();
        }

        [HttpPost()]
        public Task<long> Create([FromBody] PersonCreateDto dto)
        {
            return _service.Create(dto);
        }
    }
}
