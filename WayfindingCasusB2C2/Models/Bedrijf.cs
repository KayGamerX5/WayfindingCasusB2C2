using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WayfindingCasusB2C2.Models
{
    [Table("tblBedrijf")]
    public class Bedrijf
    {

        [Key]
        public int BedrijfId { get; set; }

        public int BedrijfDetailId { get; set; }

        public BedrijfDetail BedrijfDetail { get; set; }

        //public int RuimteId { get; set; }

        //public Ruimte Ruimte { get; set; }


        public ICollection<Plattegrond> Plattegronds { get; set; }
        public ICollection<Ruimte> Ruimtes { get; set; }
        public ICollection<Gebruiker> Gebruikeres { get; set; }
    }
}
