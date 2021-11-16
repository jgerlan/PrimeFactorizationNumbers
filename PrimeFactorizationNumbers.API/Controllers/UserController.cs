using Microsoft.AspNetCore.Mvc;
using PrimeFactorizationNumbers.Application.Dtos;
using PrimeFactorizationNumbers.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace PrimeFactorizationNumbers.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IApplicationServiceUser applicationServiceUser;

        public UsersController(IApplicationServiceUser applicationServiceUser)
        {
            this.applicationServiceUser = applicationServiceUser;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceUser.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceUser.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] UserDto userDTO)
        {
            try
            {
                if (userDTO == null)
                    return NotFound();

                applicationServiceUser.Add(userDTO);
                return Ok("Usuário Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] UserDto userDTO)
        {
            try
            {
                if (userDTO == null)
                    return NotFound();

                applicationServiceUser.Update(userDTO);
                return Ok("Usuário Atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] UserDto userDTO)
        {
            try
            {
                if (userDTO == null)
                    return NotFound();

                applicationServiceUser.Remove(userDTO);
                return Ok("Usuário Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
