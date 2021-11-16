using PrimeFactorizationNumbers.Application.Dtos;
using PrimeFactorizationNumbers.Domain.Entities;
using System.Collections.Generic;

namespace PrimeFactorizationNumbers.Application.Interfaces.IMappers
{
    public interface IMapperNumber
    {
        Number MapperDtoToEntity(NumberDto numberDto);
        IEnumerable<NumberDto> MapperListNumberDto(IEnumerable<Number> numbers);
        NumberDto MapperEntityToDto(Number number);
    }
}
