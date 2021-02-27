using Connection;
using Connection.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace av_challenge_api.Pais.Services
{
    public class PaisService: IService<PaisEntity>
    {

        private readonly DbSet<PaisEntity> _paisRepo;

        public PaisService(ApiContext context)
        {
            _paisRepo = context.paisRepository;
        }

        public List<PaisEntity> Find()
        {
            return _paisRepo.ToList();
        }

        public PaisEntity FindById(int id)
        {
            return _paisRepo.Find(id);
        }

    }
}
