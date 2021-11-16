using PrimeFactorizationNumbers.Application.Dtos;
using System.Collections.Generic;

namespace PrimeFactorizationNumbers.Application.Interfaces
{
    public interface IApplicationServiceNumber
    {
        void Add(NumberDto numberDto);
        void Update(NumberDto numberDto);
        void Remove(NumberDto numberDto);
        IEnumerable<NumberDto> GetAll();
        NumberDto GetById(int id);
    }
}
