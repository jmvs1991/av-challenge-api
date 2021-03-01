using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;

namespace Connection.Entities
{
    [Table("PRONOSTICO")]
    public class PronosticoEntity
    {

        [Key]
        [Column("ID_PRONOSTICO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdPronostico { get; set; }

        [Required]
        [Column("ID_CIUDAD")]
        public int IdCiudad { get; set; }

        [ForeignKey("IdCiudad")]
        public CiudadEntity Ciudad { get; set; }

        [Required]
        [Column("FECHA")]
        public long Fecha { get; set; }

        [NotMapped]
        public string Dia => DateTime.ParseExact(Fecha.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).DayOfWeek.ToString();

        [Required]
        [Column("TEMPERATURA")]
        public int Temperatura { get; set; }

        [NotMapped]
        public int TemperatureF => 32 + (int)(Temperatura / 0.5556);

        [Required]
        [Column("CLIMA")]
        public string Clima { get; set; }

        [Required]
        [Column("PRECIPITACION")]
        public int Precipitacion { get; set; }

        [Required]
        [Column("HUMEDAD")]
        public int Humedad { get; set; }

        [Required]
        [Column("VIENTO")]
        public int Viento { get; set; }

    }
}
