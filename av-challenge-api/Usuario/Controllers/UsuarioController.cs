using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using av_challenge_api.Usuario.Services;
using Connection;
using Connection.Entities;
using av_challenge_api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace av_challenge_api.Usuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly UsuarioService _usuarioService;

        public UsuarioController(ApiContext context)
        {

            _usuarioService = new UsuarioService(context);

        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public ActionResult<UsuarioResponse> Get()
        {

            IResponse<UsuarioEntity> respuesta = new UsuarioResponse();

            try
            {

                List<UsuarioEntity> usuarios = _usuarioService.Find() ?? new List<UsuarioEntity>();

                respuesta.Resultado = "S";
                respuesta.Datos = usuarios;


            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public ActionResult<UsuarioResponse> Get(int id)
        {
            IResponse<UsuarioEntity> respuesta = new UsuarioResponse();

            try
            {

                UsuarioEntity usuario = _usuarioService.FindById(id);

                if (usuario != null)
                {

                    respuesta.Resultado = "S";
                    respuesta.Datos.Add(usuario);

                }
                else 
                {

                    respuesta.Resultado = "N";
                    respuesta.Mensaje = "Usuario no encontrado";

                }

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        // POST api/<UsuarioController>
        [HttpPost("Login")]
        public ActionResult<UsuarioResponse> Login([FromBody] UsuarioRequest.Login login)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            IResponse<UsuarioEntity> respuesta = new UsuarioResponse();

            try
            {

                UsuarioEntity usuario = _usuarioService.Login(login.Usuario, login.Clave);

                if (usuario != null)
                {

                    respuesta.Resultado = "S";
                    respuesta.Datos.Add(usuario);

                }
                else
                {

                    respuesta.Resultado = "N";
                    respuesta.Mensaje = "Usuario o clave incorrecto";

                }

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
