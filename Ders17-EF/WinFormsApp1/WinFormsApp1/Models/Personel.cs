using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.Models
{
    [Table("Personeller")]
    public class Personel
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string AdiSoyadi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public int SubeId { get; set; }

        public virtual Sube Sube { get; set; }
    }
}
