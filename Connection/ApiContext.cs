using Connection.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using Connection.Utils;

namespace Connection
{
    public class ApiContext : DbContext
    {

        public DbSet<UsuarioEntity> usuarioRepository { get; set; }

        public DbSet<PaisEntity> paisRepository { get; set; }

        public DbSet<CiudadEntity> ciudadRepository { get; set; }

        public DbSet<PronosticoEntity> pronosticoRepository { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
           : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            List<UsuarioEntity> usuariosInit = new List<UsuarioEntity> {
                new UsuarioEntity
                {
                    IdUsuario = 1,
                    Usuario = "americavirtual@gmail.com",
                    Clave = "challenge2021",
                    Nombre = "José Vásquez",
                    Correo = ""
                }
            };
            List<PaisEntity> paisesInit = new List<PaisEntity>
            {
                new PaisEntity { IdPais = 1, Nombre = "Argentina", CodigoIso = "AR" },
                new PaisEntity { IdPais = 2, Nombre = "Brasil", CodigoIso = "BR" },
                new PaisEntity { IdPais = 3, Nombre = "Uruguay", CodigoIso = "UY" }
            };
            List<CiudadEntity> ciudadesInit = new List<CiudadEntity>
            {
                new CiudadEntity { IdCiudad = 1, IdPais = 1, Nombre = "Buenos Aires" },
                new CiudadEntity { IdCiudad = 2, IdPais = 1, Nombre = "Córdoba" },
                new CiudadEntity { IdCiudad = 3, IdPais = 1, Nombre = "Rosario" },
                new CiudadEntity { IdCiudad = 4, IdPais = 1, Nombre = "Mar del Plata" },
                new CiudadEntity { IdCiudad = 5, IdPais = 1, Nombre = "San Miguel de Tucumán" },
                new CiudadEntity { IdCiudad = 6, IdPais = 1, Nombre = "Salta" },
                new CiudadEntity { IdCiudad = 7, IdPais = 1, Nombre = "Santa Fe" },
                new CiudadEntity { IdCiudad = 8, IdPais = 1, Nombre = "Corrientes" },
                new CiudadEntity { IdCiudad = 9, IdPais = 1, Nombre = "Bahía Blanca" },
                new CiudadEntity { IdCiudad = 10, IdPais = 1, Nombre = "Resistencia" },
                new CiudadEntity { IdCiudad = 11, IdPais = 2, Nombre = "Sao Paulo" },
                new CiudadEntity { IdCiudad = 12, IdPais = 2, Nombre = "Río de Janeiro" },
                new CiudadEntity { IdCiudad = 13, IdPais = 2, Nombre = "Salvador" },
                new CiudadEntity { IdCiudad = 14, IdPais = 2, Nombre = "Brasilia" },
                new CiudadEntity { IdCiudad = 15, IdPais = 2, Nombre = "Fortaleza" },
                new CiudadEntity { IdCiudad = 16, IdPais = 2, Nombre = "Belo Horizonte" },
                new CiudadEntity { IdCiudad = 17, IdPais = 2, Nombre = "Manaos" },
                new CiudadEntity { IdCiudad = 18, IdPais = 2, Nombre = "Curitiba" },
                new CiudadEntity { IdCiudad = 19, IdPais = 2, Nombre = "Recife" },
                new CiudadEntity { IdCiudad = 20, IdPais = 2, Nombre = "Porto Alegre" },
                new CiudadEntity { IdCiudad = 21, IdPais = 3, Nombre = "Montevideo" },
                new CiudadEntity { IdCiudad = 22, IdPais = 3, Nombre = "Salto" },
                new CiudadEntity { IdCiudad = 23, IdPais = 3, Nombre = "Paysandú" },
                new CiudadEntity { IdCiudad = 24, IdPais = 3, Nombre = "Maldonado" },
                new CiudadEntity { IdCiudad = 25, IdPais = 3, Nombre = "Rivera" },
                new CiudadEntity { IdCiudad = 26, IdPais = 3, Nombre = "Tacuarembó" },
                new CiudadEntity { IdCiudad = 27, IdPais = 3, Nombre = "Melo" },
                new CiudadEntity { IdCiudad = 28, IdPais = 3, Nombre = "Artigas" },
                new CiudadEntity { IdCiudad = 29, IdPais = 3, Nombre = "Mercedes" },
                new CiudadEntity { IdCiudad = 30, IdPais = 3, Nombre = "Minas" }
            };

            int idPronostico = 0;
            List <PronosticoEntity> pronosticosInit = new List<PronosticoEntity>();

            Random rng = new Random();
            Array values = Enum.GetValues(typeof(Utils.Utils.Clima));

            Enumerable.Range(0, 30).ToList().ForEach(jv =>
            {
                long fechaL = Convert.ToInt64(DateTime.Now.AddDays(jv).ToString("yyyyMMdd"));

                ciudadesInit.ForEach(ciudad =>
                {

                    idPronostico++;

                    PronosticoEntity pronostico = new PronosticoEntity();
                    pronostico.IdPronostico = idPronostico;
                    pronostico.IdCiudad = ciudad.IdCiudad;
                    pronostico.Fecha = fechaL;
                    pronostico.Temperatura = rng.Next(-20, 55);
                    pronostico.Precipitacion = rng.Next(0, 100);
                    pronostico.Humedad = rng.Next(0, 100);
                    pronostico.Viento = rng.Next(0, 30);
                    pronostico.Clima = values.GetValue(rng.Next(values.Length)).ToString();

                    pronosticosInit.Add(pronostico);

                });
                
            });

            builder.Entity<UsuarioEntity>().HasIndex(t => t.Usuario).IsUnique();
            builder.Entity<UsuarioEntity>().Property(t => t.Correo).HasDefaultValue("");

            builder.Entity<PaisEntity>().HasIndex(p => p.CodigoIso).IsUnique();

            builder.Entity<PronosticoEntity>().HasIndex(p => new { p.Fecha, p.IdCiudad }).IsUnique();

            builder.Entity<UsuarioEntity>().HasData(usuariosInit.ToArray());
            builder.Entity<PaisEntity>().HasData(paisesInit.ToArray());
            builder.Entity<CiudadEntity>().HasData(ciudadesInit.ToArray());
            builder.Entity<PronosticoEntity>().HasData(pronosticosInit.ToArray());

        }

    }

}
