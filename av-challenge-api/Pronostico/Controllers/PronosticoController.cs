using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using av_challenge_api.Pronostico.Services;
using av_challenge_api.Models;
using Connection;
using Connection.Entities;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace av_challenge_api.Pronostico.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class PronosticoController : ControllerBase
    {

        private readonly PronosticoService _pronosticoService;

        public PronosticoController(ApiContext context)
        {

            _pronosticoService = new PronosticoService(context);

        }

        [HttpGet]
        public ActionResult<PronosticoResponse> Get()
        {

            IResponse<PronosticoEntity> respuesta = new PronosticoResponse();

            try
            {

                List<PronosticoEntity> pronosticos = _pronosticoService.Find() ?? new List<PronosticoEntity>();

                respuesta.Resultado = "S";
                respuesta.Datos = pronosticos;


            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        [HttpGet("{id}")]
        public ActionResult<PronosticoResponse> Get(int id)
        {
            IResponse<PronosticoEntity> respuesta = new PronosticoResponse();

            try
            {

                PronosticoEntity pronostico = _pronosticoService.FindById(id);

                if (pronostico != null)
                {

                    respuesta.Resultado = "S";
                    respuesta.Datos.Add(pronostico);

                }
                else
                {

                    respuesta.Resultado = "N";
                    respuesta.Mensaje = "Pronostico no encontrado";

                }

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        [HttpGet("GetByIdCiudadAndFecha/{idCiudad}/{fechaI}/{fechaF}")]
        public ActionResult<PronosticoResponse> GetByIdCiudadAndFecha(int idCiudad, long fechaI, long fechaF)
        {
            
            IResponse<PronosticoEntity> respuesta = new PronosticoResponse();

            try
            {

                List<PronosticoEntity> pronosticos = _pronosticoService.FindByIdCiudadAndFecha(idCiudad, fechaI, fechaF) ?? new List<PronosticoEntity>();

                respuesta.Resultado = "S";
                respuesta.Datos = pronosticos;

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
