﻿using AutoMapper;

namespace Pets.Services.Mapper;
public interface IMapTo<T>
{
    void MappingTo(Profile profile)
    {
        profile.CreateMap(GetType(), typeof(T));
    }
}