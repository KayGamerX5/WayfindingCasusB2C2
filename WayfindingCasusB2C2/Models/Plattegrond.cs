using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WayfindingCasusB2C2.Models
{
    [Table("tblPlattegrond")]
    public class Plattegrond
    {
        [Key]
        public int PlattegrondId { get; set; }

        public int RuimteId { get; set; }

        public Ruimte Ruimte { get; set; }

        public int BedrijfId { get; set; }

        public Bedrijf Bedrijf { get; set; }

        public int LegendaId { get; set; }
        
        public Legenda Legenda { get; set; }

        public int PlattegrondVerdieping { get; set; }

        public int RouteId { get; set; }

        public Route Route { get; set; }


    }
}
