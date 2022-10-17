using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WayfindingCasusB2C2.Models
{
    [Table("tblGebruiker")]
    public class Gebruiker
    {

        [Key]
        public int GebruikerId { get; set; }

        public string GebruikerNaam { get; set; }

        public int? BedrijfId { get; set; }

        public Bedrijf Bedrijf { get; set; }

        public int? GebruikerLeeftijd { get; set; }

        public string? GebruikerGeslacht { get; set; }

        public string GebruikerEmail { get; set; }

        public int RuimteId { get; set; }

        public Ruimte Ruimte { get; set; }

    }
}
