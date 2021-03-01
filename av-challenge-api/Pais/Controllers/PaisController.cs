using av_challenge_api.Models;
using av_challenge_api.Pais.Services;
using Connection;
using Connection.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace av_challenge_api.Pais.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class PaisController : ControllerBase
    {

        private readonly PaisService _paisService;

        public PaisController(ApiContext context)
        {

            _paisService = new PaisService(context);

        }

        [HttpGet]
        public ActionResult<PaisResponse> Get()
        {

            IResponse<PaisEntity> respuesta = new PaisResponse();

            try
            {

                List<PaisEntity> paises = _paisService.Find() ?? new List<PaisEntity>();

                respuesta.Resultado = "S";
                respuesta.Datos = paises;


            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        [HttpGet("{id}")]
        public ActionResult<PaisResponse> Get(int id)
        {
            IResponse<PaisEntity> respuesta = new PaisResponse();

            try
            {

                PaisEntity pais = _paisService.FindById(id);

                if (pais != null)
                {

                    respuesta.Resultado = "S";
                    respuesta.Datos.Add(pais);

                }
                else
                {

                    respuesta.Resultado = "N";
                    respuesta.Mensaje = "País no encontrado";

                }

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        [HttpPost]
        public ActionResult<PaisResponse> Post([FromBody] PaisRequest.PaisCreate createPais)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IResponse<PaisEntity> respuesta = new PaisResponse();

            try
            {

                PaisEntity pais = _paisService.Create(createPais);
                respuesta.Resultado = "S";
                respuesta.Datos.Add(pais);

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }

        [HttpPut("{id}")]
        public ActionResult<PaisResponse> Put(int id, [FromBody] PaisRequest.PaisUpdate updatePais)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            IResponse<PaisEntity> respuesta = new PaisResponse();

            try
            {

                PaisEntity pais = _paisService.Update(id, updatePais);

                respuesta.Resultado = "S";
                respuesta.Datos.Add(pais);

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }

        [HttpDelete("{id}")]
        public ActionResult<PaisResponse> Delete(int id)
        {

            IResponse<PaisEntity> respuesta = new PaisResponse();

            try
            {

                bool resDelete = _paisService.Delete(id);
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
