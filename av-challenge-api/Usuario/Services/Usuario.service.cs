using Connection.Entities;
using Connection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace av_challenge_api.Usuario.Services
{
    public class UsuarioService : IService<UsuarioEntity>
    {

        private readonly DbSet<UsuarioEntity> _usuarioRepo;

        public UsuarioService(ApiContext context)
        {
            _usuarioRepo = context.usuarioRepository;
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

    }
}
