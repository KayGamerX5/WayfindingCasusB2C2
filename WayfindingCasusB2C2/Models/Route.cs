using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WayfindingCasusB2C2.Models
{
    [Table("tblRoute")]
    public class Route
    {

        [Key]
        public int RouteId { get; set; }

        public string RouteBeschrijving { get; set; }

        public int LocatieId { get; set; }

        public ICollection<Plattegrond> Plattegronds { get; set; }
    }
}
