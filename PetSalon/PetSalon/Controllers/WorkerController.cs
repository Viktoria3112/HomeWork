using Microsoft.AspNetCore.Mvc;
using Pets.Services;
using Pets.Services.Dto;

namespace PetSalon.Controllers
{
    public class WorkerController
    {
        [ApiController]
        [Route("[controller]")]
        public class WorkersController : ControllerBase
        {
            private readonly IWorkerService _service;

            public WorkersController(IWorkerService service)
            {
                _service = service;
            }

            public IWorkerService Get_service()
            {
                return _service;
            }

            [HttpGet()]
            public Task<List<WorkerDto>> Get(IWorkerService _service)
            {
                return _service.GetAll();
            }

            [HttpPost()]
            public Task<long> Create([FromBody] WorkerCreateDto dto)
            {
                return _service.Create(dto);
            }
        }
    }
}
