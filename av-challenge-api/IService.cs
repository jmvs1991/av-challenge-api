using System.Collections.Generic;

namespace av_challenge_api
{
    interface IService<Entity, rqCreate, rqUpdate>
    {

        public List<Entity> Find();

        public Entity FindById(int id);

        public Entity Create(rqCreate create);

        public Entity Update(int id, rqUpdate update);

        public bool Delete(int id);

    }
}
