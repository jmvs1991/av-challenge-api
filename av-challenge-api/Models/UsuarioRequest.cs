using System.ComponentModel.DataAnnotations;

namespace av_challenge_api.Models
{
    public class UsuarioRequest
    {

        public abstract class UsuarioBase
        {
            [Required(ErrorMessage = "El campo usuario es obligatorio")]
            public string Usuario { get; set; }

            [Required(ErrorMessage = "El campo clave es obligatorio")]
            public string Clave { get; set; }
        }

        public sealed class UsuarioCreate : UsuarioBase
        {

            [Required]
            public string Nombre { get; set; }

            public string Correo { get; set; }

        }

        public sealed class UsuarioUpdate
        {
            
            public string Nombre { get; set; }

            public string Correo { get; set; }

            public string Clave { get; set; }

        }

        public sealed class UsuarioLogin : UsuarioBase
        {

        }

    }
}
