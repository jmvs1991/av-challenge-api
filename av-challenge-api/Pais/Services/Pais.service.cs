using av_challenge_api.Models;
using Connection;
using Connection.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace av_challenge_api.Pais.Services
{
    public class PaisService: IService<PaisEntity, PaisRequest.PaisCreate, PaisRequest.PaisUpdate>
    {

        private readonly DbSet<PaisEntity> _paisRepo;
        private DbContext _context;

        public PaisService(ApiContext context)
        {
            _paisRepo = context.paisRepository;
            _context = context;
        }

        public List<PaisEntity> Find()
        {
            return _paisRepo.ToList();
        }

        public PaisEntity FindById(int id)
        {
            return _paisRepo.Include(pais => pais.Ciudades)
                            .First(pais => pais.IdPais == id);
        }

        public PaisEntity Create(PaisRequest.PaisCreate pais)
        {

            PaisEntity paisEntity = new PaisEntity();
            paisEntity.Nombre = pais.Nombre;
            paisEntity.CodigoIso = pais.CodigoIso;

            EntityEntry<PaisEntity> nuevoPais = _paisRepo.Add(paisEntity);
            _context.SaveChanges();

            return nuevoPais.Entity;

        }

        public PaisEntity Update(int id, PaisRequest.PaisUpdate pais)
        {

            PaisEntity paisEntity = _paisRepo.Find(id);

            if (paisEntity == null)
            {
                throw new Exception("País no encontrado");
            }

            paisEntity.Nombre = pais.Nombre == "" || pais.Nombre == null ? paisEntity.Nombre : pais.Nombre;
            paisEntity.CodigoIso = pais.CodigoIso == "" || pais.CodigoIso == null ? paisEntity.CodigoIso : pais.CodigoIso;

            EntityEntry<PaisEntity> updatePais = _paisRepo.Update(paisEntity);
            _context.SaveChanges();

            return updatePais.Entity;

        }

        public bool Delete(int id)
        {

            PaisEntity paisEntity = _paisRepo.Find(id);

            if (paisEntity == null)
            {
                throw new Exception("País no encontrado");
            }

            _paisRepo.Remove(paisEntity);
            _context.SaveChanges();
            return true;

        }

    }
}
