using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace av_challenge_api
{
    interface IResponse<T>
    {
        string Resultado { get; set; }

        string Mensaje { get; set; }

        List<T> Datos { get; set; }
    }
}
