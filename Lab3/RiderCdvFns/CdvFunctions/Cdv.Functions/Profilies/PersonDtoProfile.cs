using AutoMapper;
using Cdv.Domain.Entities;
using Cdv.Functions.Dto;

namespace Cdv.Functions.Profilies;

public class PersonDtoProfile :Profile
{
    public PersonDtoProfile()
    {
        CreateMap<PersonDto, PersonEntity>();
    }
}