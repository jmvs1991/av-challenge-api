using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Connection.Entities
{
    [Table("CIUDAD")]
    public class CiudadEntity
    {

        [Key]
        [Column("ID_CIUDAD")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCiudad { get; set; }

        [Column("ID_PAIS")]
        public int IdPais { get; set; }

        [ForeignKey("IdPais")]
        public PaisEntity Pais { get; set; }

        [Required]
        [Column("NOMBRE")]
        public string Nombre { get; set; }

        public List<PronosticoEntity> Pronosticos { get; set; }
              

    }
}
