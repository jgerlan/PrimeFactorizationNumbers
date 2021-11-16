using PrimeFactorizationNumbers.Application.Dtos;
using PrimeFactorizationNumbers.Application.Interfaces.IMappers;
using PrimeFactorizationNumbers.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactorizationNumbers.Application.Mappers
{
    public class MapperNumber : IMapperNumber
    {
        public Number MapperDtoToEntity(NumberDto numberDto)
        {
            var number = new Number()
            {
                Id = numberDto.Id
            };

            return number;
        }

        public NumberDto MapperEntityToDto(Number number)
        {
            var numberDto = new NumberDto()
            {
                Id = number.Id
            };

            return numberDto;
        }

        public IEnumerable<NumberDto> MapperListNumberDto(IEnumerable<Number> numbers)
        {
            var dto = numbers.Select(c => new NumberDto
            {
                Id = c.Id
            });

            return dto;
        }
    }
}
