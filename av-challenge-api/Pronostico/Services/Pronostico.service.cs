using av_challenge_api.Models;
using Connection;
using Connection.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace av_challenge_api.Pronostico.Services
{
    public class PronosticoService : IService<PronosticoEntity, PronosticoRequest.PronosticoCreate, PronosticoRequest.PronosticoUpdate>
    {

        private readonly DbSet<PronosticoEntity> _pronosticoRepo;
        private DbContext _context;

        public PronosticoService(ApiContext context)
        {
            _pronosticoRepo = context.pronosticoRepository;
            _context = context;
        }

        public List<PronosticoEntity> Find()
        {
            return _pronosticoRepo.ToList();
        }

        public PronosticoEntity FindById(int id)
        {
            return _pronosticoRepo.Include(pronos => pronos.Ciudad)
                                  .ThenInclude(ciudad => ciudad.Pais)
                                  .First(pronos => pronos.IdPronostico == id);
        }

        public List<PronosticoEntity> FindByIdCiudadAndFecha(int id, long FechaI, long FechaF)
        {
            return _pronosticoRepo.Where(pronostico => pronostico.IdCiudad == id && pronostico.Fecha >= FechaI && pronostico.Fecha <= FechaF).ToList();
        }

        public PronosticoEntity Create(PronosticoRequest.PronosticoCreate pronostico)
        {

            throw new Exception("No implementado");

        }

        public PronosticoEntity Update(int id, PronosticoRequest.PronosticoUpdate pais)
        {

            throw new Exception("No implementado");

        }

        public bool Delete(int id)
        {

            throw new Exception("No implementado");

        }

    }
}
