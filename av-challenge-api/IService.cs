using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace av_challenge_api
{
    interface IService<Entity>
    {

        public List<Entity> Find();

        public Entity FindById(int id);

    }
}
