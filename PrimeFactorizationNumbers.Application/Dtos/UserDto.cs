using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeFactorizationNumbers.Application.Dtos
{
    public class UserDto
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
    }
}
