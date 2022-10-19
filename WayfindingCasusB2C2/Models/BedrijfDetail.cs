using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WayfindingCasusB2C2.Models
{
    [Table("tblBedrijfDetail")]
    public class BedrijfDetail
    {

        [Key]
        public int BedrijfDetailsId { get; set; }

        public string BedrijfNaam { get; set; }

        public string BedrijfEigenaar { get; set; }

        public int BedrijfMedewerkers { get; set; }

        public string? BedrijfDoelen { get; set; }

        public int BedrijfOpgerichtJaar { get; set; }

        public string? BedrijfBeschrijving { get; set; }

        public ICollection<Bedrijf> Bedrijfs { get; set; }

    }
}
