using LJBPDemo.Application.DTOs;
using LJBPDemo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LJBPDemo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private readonly IApplicationServicePersona applicationServicePersona;


        public PersonasController(IApplicationServicePersona applicationServicePersona)
        {
            this.applicationServicePersona = applicationServicePersona;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServicePersona.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServicePersona.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PersonaDTO personaDTO)
        {
            try
            {
                if (personaDTO == null)
                    return NotFound();

                applicationServicePersona.Add(personaDTO);
                return Ok("¡Persona Registrada Exitosamente!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PersonaDTO personaDTO)
        {
            try
            {
                if (personaDTO == null)
                    return NotFound();

                applicationServicePersona.Update(personaDTO);
                return Ok("¡Persona actualizado con éxito!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PersonaDTO personaDTO)
        {
            try
            {
                if (personaDTO == null)
                    return NotFound();

                applicationServicePersona.Delete(personaDTO);
                return Ok("¡Persona eliminada con éxito!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

