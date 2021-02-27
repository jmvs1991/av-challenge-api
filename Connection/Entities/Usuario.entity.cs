using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Connection.Entities
{
    [Table("USUARIO")]
    public class UsuarioEntity
    {

        [Key]
        [Column("ID_USUARIO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Required]
        [Column("USUARIO")]
        public string Usuario { get; set; }

        [Required]
        [Column("CLAVE")]
        public string Clave { get; set; }

        [Required]
        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("CORREO")]
        public string Correo { get; set; }

    }
}
