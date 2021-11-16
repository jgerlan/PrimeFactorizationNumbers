using Microsoft.AspNetCore.Mvc;
using PrimeFactorizationNumbers.Application.Dtos;
using PrimeFactorizationNumbers.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace PrimeFactorizationNumbers.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        private readonly IApplicationServiceNumber applicationServiceNumber;

        public NumberController(IApplicationServiceNumber applicationServiceNumber)
        {
            this.applicationServiceNumber = applicationServiceNumber;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceNumber.GetAll());
        }

        // GET api/values/5\
        [HttpGet("GetDivisors/{id}")]
        public ActionResult<string> GetDivisors(int id)
        {
            int num = id;

            for (int i = 1; i <= num; i++)
            {
                int numeroDivisores = 0;

                if (num % i == 0)
                {
                    Console.Write("* Número divisor: ");
                    Console.WriteLine("" + i);
                    Console.WriteLine();

                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            numeroDivisores++;
                        }
                    }

                    if (numeroDivisores == 2)
                    {
                        Console.WriteLine("* Divisor primo: " + i);
                        Console.WriteLine();
                    }
                }
            }

            return Ok(applicationServiceNumber.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] NumberDto numberDTO)
        {
            try
            {
                if (numberDTO == null)
                    return NotFound();

                applicationServiceNumber.Add(numberDTO);
                return Ok("O número foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] NumberDto numberDTO)
        {
            try
            {
                if (numberDTO == null)
                    return NotFound();

                applicationServiceNumber.Update(numberDTO);
                return Ok("O número foi atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] NumberDto numberDTO)
        {
            try
            {
                if (numberDTO == null)
                    return NotFound();

                applicationServiceNumber.Remove(numberDTO);
                return Ok("O número foi removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
