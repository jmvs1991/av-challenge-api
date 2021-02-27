using Connection.Entities;
using Microsoft.EntityFrameworkCore;

namespace Connection
{
    public class ApiContext : DbContext
    {

        public DbSet<UsuarioEntity> usuarioRepository { get; set; }

        public DbSet<PaisEntity> paisRepository { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
           : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<UsuarioEntity>().HasIndex(t => t.Usuario).IsUnique();
            builder.Entity<UsuarioEntity>().Property(t => t.Correo).HasDefaultValue("");
            builder.Entity<UsuarioEntity>().HasData(
                new UsuarioEntity
                {
                    IdUsuario = 1,
                    Usuario = "americavirtual@gmail.com",
                    Clave = "challenge2021",
                    Nombre = "José Vásquez",
                    Correo = ""
                }
                );

            builder.Entity<PaisEntity>().HasIndex(p => p.CodigoIso).IsUnique();

            builder.Entity<PaisEntity>().HasData(
                   new PaisEntity
                   {
                       IdPais = 1,
                       Nombre = "Argentina",
                       CodigoIso = "AR"
                   }
               );
        }

    }

}
