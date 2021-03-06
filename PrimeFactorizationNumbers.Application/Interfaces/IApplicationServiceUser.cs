using PrimeFactorizationNumbers.Application.Dtos;
using System.Collections.Generic;

namespace PrimeFactorizationNumbers.Application.Interfaces
{
    public interface IApplicationServiceUser
    {
        void Add(UserDto userDto);
        void Update(UserDto userDto);
        void Remove(UserDto userDto);
        IEnumerable<UserDto> GetAll();
        UserDto GetById(int id);
    }
}
