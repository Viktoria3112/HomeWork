using AutoMapper;
using Pets.Services.Dto;
using PetsEntity;
using Microsoft.EntityFrameworkCore;
using PetInfrastructure;
using AutoMapper.QueryableExtensions;

namespace Pets.Services
{
    public interface IWorkerService
    {
        Task<List<WorkerDto>> GetAll();
        Task<long> Create(WorkerCreateDto dto);
    }

    public class WorkersService : IWorkerService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public WorkersService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task<List<WorkerDto>> GetAll()
        {
            return _dbContext.Workers.ProjectTo<WorkerDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<long> Create(WorkerCreateDto dto)
        {
            var entity = _mapper.Map<Worker>(dto);
            _dbContext.Workers.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }
    }


}

