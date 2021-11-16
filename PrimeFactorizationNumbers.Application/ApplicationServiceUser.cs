using PrimeFactorizationNumbers.Application.Dtos;
using PrimeFactorizationNumbers.Application.Interfaces;
using PrimeFactorizationNumbers.Application.Interfaces.IMappers;
using PrimeFactorizationNumbers.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace PrimeFactorizationNumbers.Application
{
    public class ApplicationServiceUser : IApplicationServiceUser
    {
        private readonly IServiceUser serviceUser;
        private readonly IMapperUser mapperUser;

        public ApplicationServiceUser(IServiceUser serviceUser
                                     , IMapperUser mapperUser)
        {
            this.serviceUser = serviceUser;
            this.mapperUser = mapperUser;
        }

        public void Add(UserDto userDto)
        {
            var user = mapperUser.MapperDtoToEntity(userDto);
            serviceUser.Add(user);
        }

        public IEnumerable<UserDto> GetAll()
        {
            var users = serviceUser.GetAll();
            return mapperUser.MapperListUserDto(users);
        }

        public UserDto GetById(int id)
        {
            var user = serviceUser.GetById(id);
            return mapperUser.MapperEntityToDto(user);
        }

        public void Remove(UserDto userDto)
        {
            var user = mapperUser.MapperDtoToEntity(userDto);
            serviceUser.Remove(user);
        }

        public void Update(UserDto userDto)
        {
            var user = mapperUser.MapperDtoToEntity(userDto);
            serviceUser.Update(user);
        }
    }
}
