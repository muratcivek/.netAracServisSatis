using OtoServisSatis.Entities;
using System.ComponentModel.DataAnnotations;

namespace aracServisSatis.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "Adı"), Required(ErrorMessage ="{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }

        [StringLength(50), Display(Name = "Soyadı")]
        public string Soyadi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Telefon { get; set; }

        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [StringLength(50)]
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
        [Display(Name = "Eklenme Tarihi"),ScaffoldColumn(false)]
        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;
        public int RolId { get; set; }
        public virtual Rol? Rol { get; set; }

        public Guid? UserGuid { get; set; } = Guid.NewGuid();
    }
}
