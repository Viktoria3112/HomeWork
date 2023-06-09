using AutoMapper;
using Pets.Services.Dto;
using PetsEntity;
using Microsoft.EntityFrameworkCore;
using PetInfrastructure;
using AutoMapper.QueryableExtensions;

namespace Pets.Services
{
    public interface IPersonService
    {
        Task<List<PersonDto>> GetAll();
        Task<long> Create(PersonCreateDto dto);
    }

    public class PersonsService : IPersonService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public PersonsService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task<List<PersonDto>> GetAll()
        {
            return _dbContext.Persons.ProjectTo<PersonDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<long> Create(PersonCreateDto dto)
        {
            var entity = _mapper.Map<Person>(dto);
            _dbContext.Persons.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }
    }
}
