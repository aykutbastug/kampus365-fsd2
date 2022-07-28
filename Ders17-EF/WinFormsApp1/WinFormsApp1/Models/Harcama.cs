using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.Models
{
    [Table("Harcamalar")]
    public class Harcama
    {
        [Key]
        public int Id { get; set; }
        public int? SubeId { get; set; }
        public int? PersonelId { get; set; }
        public string FisNo { get; set; }
        public DateTime HarcamaTarihi { get; set; }


        public virtual Sube Sube { get; set; }
        public virtual Personel Personel { get; set; }
        public List<HarcamaDetay> HarcamaDetaylari { get; set; }
    }
}
