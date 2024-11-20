using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace aracServisSatis.Entities
{
    public class Arac : IEntity
    {
       
        public int Id { get; set; }
        public int MarkaId { get; set; }
        [StringLength(50)]
        public string Renk { get; set; }
        public decimal Fiyati { get; set; }
        [StringLength(50)]
        public string Modeli { get; set; }
        [StringLength(50)]
        public string KasaTipi { get; set; }
        public int ModelYili { get; set; }
        public bool SatistaMi { get; set; }
        [Display(Name = "AnaSayfa?")]
        public bool AnaSayfa { get; set; }
        public string Notlar { get; set; }

        [StringLength(100)]
        public string? Resim1 { get; set; }


        [StringLength(100)]
        public string? Resim2 { get; set; }

        [StringLength(100)]
        public string? Resim3 { get; set; }

        public virtual Marka? marka { get; set; }
    }
}
