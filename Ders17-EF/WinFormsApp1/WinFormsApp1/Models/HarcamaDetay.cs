using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.Models
{
    [Table("HarcamaDetaylari")]
    public class HarcamaDetay
    {
        [Key]
        public int Id { get; set; }
        public int HarcamaId { get; set; }
        public string Aciklama { get; set; }
        public decimal Tutar { get; set; } = 0;


        public virtual Harcama Harcama { get; set; }
    }
}
