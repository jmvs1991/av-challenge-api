using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using av_challenge_api.Ciudad.Service;
using Connection;
using Connection.Entities;
using av_challenge_api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace av_challenge_api.Ciudad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {

        private readonly CiudadService _ciudadService;

        public CiudadController(ApiContext context)
        {

            _ciudadService = new CiudadService(context);

        }

        [HttpGet]
        public ActionResult<CiudadResponse> Get()
        {

            IResponse<CiudadEntity> respuesta = new CiudadResponse();

            try
            {

                List<CiudadEntity> ciudades = _ciudadService.Find() ?? new List<CiudadEntity>();

                respuesta.Resultado = "S";
                respuesta.Datos = ciudades;

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        [HttpGet("{id}")]
        public ActionResult<CiudadResponse> Get(int id)
        {

            IResponse<CiudadEntity> respuesta = new CiudadResponse();

            try
            {

                CiudadEntity ciudad = _ciudadService.FindById(id);

                if (ciudad != null)
                {

                    respuesta.Resultado = "S";
                    respuesta.Datos.Add(ciudad);

                }
                else
                {

                    respuesta.Resultado = "N";
                    respuesta.Mensaje = "Ciudad no encontrada";

                }

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        [HttpGet("GetByIdPais/{idPais}")]
        public ActionResult<CiudadResponse> GetByIdPais(int idPais)
        {

            IResponse<CiudadEntity> respuesta = new CiudadResponse();

            try
            {

                List<CiudadEntity> ciudades = _ciudadService.FindByIdPais(idPais) ?? new List<CiudadEntity>();

                respuesta.Resultado = "S";
                respuesta.Datos = ciudades;

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        // POST api/<CiudadController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CiudadController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CiudadController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
