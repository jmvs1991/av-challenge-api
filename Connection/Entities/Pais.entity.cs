using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Connection.Entities
{
    [Table("PAIS")]
    public class PaisEntity
    {

        [Key]
        [Column("ID_PAIS")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPais { get; set; }

        [Required]
        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Required]
        [Column("CODIGO_ISO")]
        public string CodigoIso { get; set; }
                
    }
}
