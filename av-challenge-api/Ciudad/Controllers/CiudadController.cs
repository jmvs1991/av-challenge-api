using av_challenge_api.Ciudad.Service;
using av_challenge_api.Models;
using Connection;
using Connection.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace av_challenge_api.Ciudad.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
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
        public ActionResult<CiudadResponse> Post([FromBody] CiudadRequest.CiudadCreate createCiudad)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IResponse<CiudadEntity> respuesta = new CiudadResponse();

            try
            {

                CiudadEntity ciudad = _ciudadService.Create(createCiudad);
                respuesta.Resultado = "S";
                respuesta.Datos.Add(ciudad);

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }

        // PUT api/<CiudadController>/5
        [HttpPut("{id}")]
        public ActionResult<CiudadResponse> Put(int id, [FromBody] CiudadRequest.CiudadUpdate updateCiudad)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IResponse<CiudadEntity> respuesta = new CiudadResponse();

            try
            {

                CiudadEntity ciudad = _ciudadService.Update(id, updateCiudad);
                respuesta.Resultado = "S";
                respuesta.Datos.Add(ciudad);

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }

        // DELETE api/<CiudadController>/5
        [HttpDelete("{id}")]
        public ActionResult<CiudadResponse> Delete(int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IResponse<CiudadEntity> respuesta = new CiudadResponse();

            try
            {

                bool resDelete = _ciudadService.Delete(id);
                respuesta.Resultado = resDelete == true ? "S" : "N";

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }
    }
}
