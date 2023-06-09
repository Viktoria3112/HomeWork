using AutoMapper;
using Pets.Services.Dto;
using PetsEntity;
using Microsoft.EntityFrameworkCore;
using PetInfrastructure;
using AutoMapper.QueryableExtensions;

namespace Pets.Services
{
    public interface IPetsService
    {
        Task<List<AnimalDto>> GetAll();
        Task<long> Create(AnimalCreateDto dto);
    }

    public class AnimalService : IPetsService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public AnimalService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task<List<AnimalDto>> GetAll()
        {
            return _dbContext.Animals.ProjectTo<AnimalDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<long> Create(AnimalCreateDto dto)
        {
            var entity = _mapper.Map<Animal>(dto);
            _dbContext.Animals.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }
    }
}