using av_challenge_api.Models;
using Connection;
using Connection.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace av_challenge_api.Usuario.Services
{
    public class UsuarioService : IService<UsuarioEntity, UsuarioRequest.UsuarioCreate, UsuarioRequest.UsuarioUpdate>
    {

        private readonly DbSet<UsuarioEntity> _usuarioRepo;
        private DbContext _context;

        public UsuarioService(ApiContext context)
        {
            _usuarioRepo = context.usuarioRepository;
            _context = context;
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
            return _usuarioRepo.First(us => us.Usuario == usuario && us.Clave == clave);
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

    }
}
