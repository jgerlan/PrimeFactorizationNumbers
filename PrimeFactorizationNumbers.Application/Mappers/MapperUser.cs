using PrimeFactorizationNumbers.Application.Dtos;
using PrimeFactorizationNumbers.Application.Interfaces.IMappers;
using PrimeFactorizationNumbers.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactorizationNumbers.Application.Mappers
{
    public class MapperUser : IMapperUser
    {
        public User MapperDtoToEntity(UserDto userDto)
        {
            var user = new User()
            {
                Id = userDto.Id,
                Nome = userDto.Nome,
                Sobrenome = userDto.Sobrenome,
                Email = userDto.Email
            };

            return user;
        }

        public UserDto MapperEntityToDto(User user)
        {
            var userDto = new UserDto()
            {
                Id = user.Id,
                Nome = user.Nome,
                Sobrenome = user.Sobrenome,
                Email = user.Email
            };

            return userDto;
        }

        public IEnumerable<UserDto> MapperListUserDto(IEnumerable<User> users)
        {
            var dto = users.Select(c => new UserDto
            {
                Id = c.Id,
                Nome = c.Nome,
                Sobrenome = c.Sobrenome,
                Email = c.Email
            });

            return dto;
        }
    }
}
