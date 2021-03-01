using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace av_challenge_api.Models
{
    public class CiudadRequest
    {

        public abstract class CiudadBase
        {
            [Required(ErrorMessage = "El campo Nombre es obligatorio")]
            public string Nombre { get; set; }

            [Required(ErrorMessage = "El campo Codigo ISO es obligatorio")]
            public int IdPais { get; set; }

        }

        public sealed class CiudadCreate : CiudadBase
        {

        }

        public sealed class CiudadUpdate
        {
            public string Nombre { get; set; }
        }
    }
}
