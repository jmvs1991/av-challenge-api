using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace av_challenge_api.Models
{
    public class UsuarioRequest
    {

        public class Login
        {
            [Required(ErrorMessage="El campo usuario es obligatorio")]
            public string Usuario { get; set; }

            [Required(ErrorMessage="El campo clave es obligatorio")]
            public string Clave { get; set; }
        }

    }
}
