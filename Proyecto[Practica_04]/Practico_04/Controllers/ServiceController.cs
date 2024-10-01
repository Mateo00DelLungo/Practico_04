using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practico_04.App;
using Practico_04.Models;

namespace Practico_04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly Aplication app;
        public ServiceController()
        {
            app = new Aplication();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await app._serviceManager.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var obj = await app._serviceManager.GetById(id);
                if(null == obj)
                {
                    return NotFound("No se encontro el ID del objeto");
                }
                return Ok(obj.ToString());
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ServicioDTO obj)
        {
            if (!obj.Validate())
            {
                return BadRequest("Error de validacion, revise los campos ingresados");
            }
            try
            {
                if (!await app._serviceManager.Save(obj))
                {
                    return StatusCode(500, "Error al insertar en la base de datos");
                }
                return Ok("Objeto registrado exitosamente");
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ServicioDTO obj)
        {
            if (!obj.Validate()) 
            { return BadRequest("Error de validacion, revise los campos ingresados; El ID debe ser uno existente"); }
            try
            {
                if(!await app._serviceManager.Update(obj))
                {
                    return NotFound("No se encontro el ID del objeto que se desea actualizar");
                }
                return Ok("Objeto actualizado exitosamente");
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpDelete("/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if(!await app._serviceManager.Delete(id))
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
