using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connection;
using Connection.Entities;
using av_challenge_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace av_challenge_api.Ciudad.Service
{
    public class CiudadService : IService<CiudadEntity, CiudadRequest.CiudadCreate, CiudadRequest.CiudadUpdate>
    {

        private readonly DbSet<CiudadEntity> _ciudadRepo;
        private readonly DbSet<PaisEntity> _paisRepo;
        private DbContext _context;

        public CiudadService(ApiContext context)
        {
            _ciudadRepo = context.ciudadRepository;
            _paisRepo = context.paisRepository;
            _context = context;
        }

        public List<CiudadEntity> Find()
        {
            return _ciudadRepo.ToList();
        }

        public CiudadEntity FindById(int id)
        {
            return _ciudadRepo.Include(ciudad => ciudad.Pais)
                              .Include(Ciudad => Ciudad.Pronosticos)
                              .First(Ciudad => Ciudad.IdCiudad == id);
        }

        public List<CiudadEntity> FindByIdPais(int id)
        {
            return _ciudadRepo.Where(ciudad => ciudad.IdPais == id).ToList();
        }

        public CiudadEntity Create(CiudadRequest.CiudadCreate ciudad)
        {

            PaisEntity pais = _paisRepo.Find(ciudad.IdPais);

            if(pais == null)
            {
                throw new Exception("País no encontrado");
            }

            CiudadEntity ciudadEntity = new CiudadEntity();
            ciudadEntity.IdPais = ciudad.IdPais;
            ciudadEntity.Nombre = ciudad.Nombre;

            EntityEntry<CiudadEntity> nuevaCiudad = _ciudadRepo.Add(ciudadEntity);
            _context.SaveChanges();

            return nuevaCiudad.Entity;

        }

        public CiudadEntity Update(int id, CiudadRequest.CiudadUpdate ciudad)
        {

            CiudadEntity ciudadEntity = _ciudadRepo.Find(id);

            if (ciudadEntity == null)
            {
                throw new Exception("Ciudad no encontrada");
            }

            ciudadEntity.Nombre = ciudad.Nombre == "" || ciudad.Nombre == null ? ciudadEntity.Nombre : ciudad.Nombre;

            EntityEntry<CiudadEntity> updateCiudad = _ciudadRepo.Update(ciudadEntity);
            _context.SaveChanges();

            return updateCiudad.Entity;

        }

        public bool Delete(int id)
        {

            CiudadEntity ciudadEntity = _ciudadRepo.Find(id);

            if (ciudadEntity == null)
            {
                throw new Exception("Ciudad no encontrada");
            }

            _ciudadRepo.Remove(ciudadEntity);
            _context.SaveChanges();
            return true;

        }

    }
}
