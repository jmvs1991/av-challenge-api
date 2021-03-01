using av_challenge_api.Models;
using av_challenge_api.Usuario.Services;
using Connection;
using Connection.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace av_challenge_api.Usuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly UsuarioService _usuarioService;

        public UsuarioController(ApiContext context, IConfiguration config)
        {

            _usuarioService = new UsuarioService(context, config);

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
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public ActionResult<UsuarioResponse> Post([FromBody] UsuarioRequest.UsuarioCreate createUsuario)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            IResponse<UsuarioEntity> respuesta = new UsuarioResponse();

            try
            {

                UsuarioEntity usuario = _usuarioService.Create(createUsuario);
                respuesta.Resultado = "S";
                respuesta.Datos.Add(usuario);

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }

        [HttpPost("Login")]
        public ActionResult<UsuarioResponse> Login([FromBody] UsuarioRequest.UsuarioLogin login)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            IResponse<UsuarioEntity> respuesta = new UsuarioResponse();

            try
            {

                UsuarioEntity usuario = _usuarioService.Login(login.Usuario, login.Clave);
                respuesta.Resultado = "S";
                respuesta.Datos.Add(usuario);

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
        [Authorize(AuthenticationSchemes = "Bearer")]
        public ActionResult<UsuarioResponse> Put(int id, [FromBody] UsuarioRequest.UsuarioUpdate updateUsuario)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            IResponse<UsuarioEntity> respuesta = new UsuarioResponse();

            try
            {

                UsuarioEntity usuario = _usuarioService.Update(id, updateUsuario);

                respuesta.Resultado = "S";
                respuesta.Datos.Add(usuario);

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public ActionResult<UsuarioResponse> Delete(int id)
        {

            IResponse<UsuarioEntity> respuesta = new UsuarioResponse();

            try
            {

                bool resDelete = _usuarioService.Delete(id);
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
