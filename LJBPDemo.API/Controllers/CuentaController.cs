using LJBPDemo.Application.DTOs;
using LJBPDemo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LJBPDemo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CuentasController : ControllerBase
    {

        private readonly IApplicationServiceCuenta applicationServiceCuenta;


        public CuentasController(IApplicationServiceCuenta applicationServiceCuenta)
        {
            this.applicationServiceCuenta = applicationServiceCuenta;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceCuenta.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceCuenta.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] CuentaDTO cuentaDTO)
        {
            try
            {
                if (cuentaDTO == null)
                    return NotFound();

                applicationServiceCuenta.Add(cuentaDTO);
                return Ok("¡Cliente Registrado Exitosamente!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] CuentaDTO cuentaDTO)
        {
            try
            {
                if (cuentaDTO == null)
                    return NotFound();

                applicationServiceCuenta.Update(cuentaDTO);
                return Ok("¡Cuenta actualizado con éxito!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] CuentaDTO cuentaDTO)
        {
            try
            {
                if (cuentaDTO == null)
                    return NotFound();

                applicationServiceCuenta.Delete(cuentaDTO);
                return Ok("¡Cuenta eliminado con éxito!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
