using PrimeFactorizationNumbers.Application.Dtos;
using PrimeFactorizationNumbers.Domain.Entities;
using System.Collections.Generic;

namespace PrimeFactorizationNumbers.Application.Interfaces.IMappers
{
    public interface IMapperUser
    {
        User MapperDtoToEntity(UserDto userDto);
        IEnumerable<UserDto> MapperListUserDto(IEnumerable<User> users);
        UserDto MapperEntityToDto(User user);
    }
}
