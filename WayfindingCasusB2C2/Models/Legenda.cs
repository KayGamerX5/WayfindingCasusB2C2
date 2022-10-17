using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WayfindingCasusB2C2.Models
{
    [Table("tblLegenda")]
    public class Legenda
    {
        [Key]
        public int LegendaId { get; set; }

        public int LegendaItem { get; set; }

        //public image LegendaIcon { get; set; }

        public string LegendaBeschrijving { get; set; }

        public ICollection<Plattegrond> Plattegronds { get; set; }
    }
}
