using System.ComponentModel.DataAnnotations;

namespace av_challenge_api.Models
{
    public class PaisRequest
    {

        public abstract class PaisBase
        {
            [Required(ErrorMessage = "El campo Nombre es obligatorio")]
            public string Nombre { get; set; }

            [Required(ErrorMessage = "El campo Codigo ISO es obligatorio")]
            public string CodigoIso { get; set; }
        }

        public sealed class PaisCreate : PaisBase
        {

        }

        public sealed class PaisUpdate : PaisBase
        {

        }

    }
}
