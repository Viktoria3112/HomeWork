using AutoMapper;
using Pets.Services.Dto;
using PetsEntity;
using Microsoft.EntityFrameworkCore;
using PetInfrastructure;
using AutoMapper.QueryableExtensions;

namespace Pets.Services
{
    public interface IServicesService
    {
        Task<List<ServiceDto>> GetAll();
        Task<long> Create(ServiceCreateDto dto);
    }

    public class ServicesService : IServicesService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public ServicesService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task<List<ServiceDto>> GetAll()
        {
            return _dbContext.Services.ProjectTo<ServiceDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<long> Create(AnimalCreateDto dto)
        {
            var entity = _mapper.Map<Animal>(dto);
            _dbContext.Animals.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }

        Task<List<ServiceDto>> IServicesService.GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<long> Create(ServiceCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
