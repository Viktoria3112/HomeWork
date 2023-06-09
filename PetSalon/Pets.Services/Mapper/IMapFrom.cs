using AutoMapper;

namespace Pets.Services.Mapper;

public interface IMapFrom<T>
{
    void MappingFrom(Profile profile)
    {
        profile.CreateMap(typeof(T), GetType());
    }
}