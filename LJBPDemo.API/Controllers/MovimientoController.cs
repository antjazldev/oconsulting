using LJBPDemo.Application.DTOs;
using LJBPDemo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LJBPDemo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovimientoController : Controller
    {

        private readonly IApplicationServiceMovimiento applicationServiceMovimiento;


        public MovimientoController(IApplicationServiceMovimiento applicationServiceMovimiento)
        {
            this.applicationServiceMovimiento = applicationServiceMovimiento;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceMovimiento.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceMovimiento.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] MovimientoDTO movimientoDTO)
        {
            try
            {
                if (movimientoDTO == null)
                    return NotFound();

                applicationServiceMovimiento.Add(movimientoDTO);
                return Ok("¡Movimiento Registrado Exitosamente!");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] MovimientoDTO movimientoDTO)
        {
            try
            {
                if (movimientoDTO == null)
                    return NotFound();

                applicationServiceMovimiento.Update(movimientoDTO);
                return Ok("¡Cuenta actualizado con éxito!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] MovimientoDTO movimientoDTO)
        {
            try
            {
                if (movimientoDTO == null)
                    return NotFound();

                applicationServiceMovimiento.Delete(movimientoDTO);
                return Ok("¡Movimiento eliminado con éxito!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
