using av_challenge_api.Models;
using Connection;
using Connection.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;

namespace av_challenge_api.Usuario.Services
{
    public class UsuarioService : IService<UsuarioEntity, UsuarioRequest.UsuarioCreate, UsuarioRequest.UsuarioUpdate>
    {

        private readonly DbSet<UsuarioEntity> _usuarioRepo;
        private readonly IConfiguration _config;
        private DbContext _context;

        public UsuarioService(ApiContext context, IConfiguration config)
        {
            _usuarioRepo = context.usuarioRepository;
            _context = context;
            _config = config;
        }

        public List<UsuarioEntity> Find()
        {
            return _usuarioRepo.ToList();
        }

        public UsuarioEntity FindById(int id)
        {
            return _usuarioRepo.Find(id);
        }

        public UsuarioEntity Login(string usuario, string clave)
        {
            UsuarioEntity usuarioEntity = _usuarioRepo.FirstOrDefault(us => us.Usuario == usuario && us.Clave == clave);

            if (usuarioEntity == null)
            {
                throw new Exception("Usuario o clave incorrecto.");
            }

            usuarioEntity.Token = GenerateJSONWebToken();

            return usuarioEntity;
        }

        public UsuarioEntity Create(UsuarioRequest.UsuarioCreate usuario)
        {

            UsuarioEntity usuarioEntity = new UsuarioEntity();
            usuarioEntity.Usuario = usuario.Usuario;
            usuarioEntity.Nombre = usuario.Nombre;
            usuarioEntity.Clave = usuario.Clave;

            EntityEntry<UsuarioEntity> nuevoUsuario = _usuarioRepo.Add(usuarioEntity);
            _context.SaveChanges();

            return nuevoUsuario.Entity;

        }

        public UsuarioEntity Update(int id, UsuarioRequest.UsuarioUpdate usuario)
        {

            UsuarioEntity usuarioEntity = _usuarioRepo.Find(id);

            if (usuarioEntity == null)
            {
                throw new Exception("El id del usuario no existe");
            }

            usuarioEntity.Nombre = usuario.Nombre == "" || usuario.Nombre == null ? usuarioEntity.Nombre : usuario.Nombre;
            usuarioEntity.Clave = usuario.Clave == "" || usuario.Clave == null ? usuarioEntity.Clave : usuario.Clave;
            usuarioEntity.Correo = usuario.Correo == null ? usuarioEntity.Correo : usuario.Correo;

            EntityEntry<UsuarioEntity> updateUsuario = _usuarioRepo.Update(usuarioEntity);
            _context.SaveChanges();

            return updateUsuario.Entity;

        }

        public bool Delete(int id)
        {

            UsuarioEntity usuarioEntity = _usuarioRepo.Find(id);

            if (usuarioEntity == null)
            {
                throw new Exception("El id del usuario no existe");
            }

            _usuarioRepo.Remove(usuarioEntity);
            _context.SaveChanges();
            return true;

        }

        private string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
              _config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
