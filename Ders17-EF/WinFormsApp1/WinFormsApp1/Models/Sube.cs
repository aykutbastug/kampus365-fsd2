using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    [Table("Subeler")]
    public class Sube
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string SubeAdi { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }

        [StringLength(11)]
        public string Telefon { get; set; }

        public List<Personel> Personeller { get; set; }
    }
}
