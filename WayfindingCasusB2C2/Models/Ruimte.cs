using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WayfindingCasusB2C2.Models
{
    [Table("tblRuimte")]
    public class Ruimte
    {
        

        [Key]
        public int RuimteId { get; set; }

        public int RuimteOppervlakte { get; set; }

        public bool RuimteBezet { get; set; }

        public int RuimteBezoekers { get; set; }

        //public int BedrijfId { get; set; }

        //public Bedrijf Bedrijf { get; set; }

        public ICollection<Gebruiker> Gebruikers { get; set; }
        public ICollection<Plattegrond> Plattegronds { get; set; }
        public ICollection<Bedrijf> Bedrijfs { get; set; }
    }
}
