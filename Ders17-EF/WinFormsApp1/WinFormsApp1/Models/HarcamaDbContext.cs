using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class HarcamaDbContext : DbContext
    {
        public DbSet<Sube> Subeler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Harcama> Harcamalar { get; set; }
        public DbSet<HarcamaDetay> HarcamaDetaylari { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer("server=AYKUTBASTUG-ZEN;DATABASE=HarcamaDb;Trusted_Connection=true;");
            }
        }
    }
}
