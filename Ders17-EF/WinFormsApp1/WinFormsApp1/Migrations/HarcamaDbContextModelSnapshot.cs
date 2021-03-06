// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp1.Models;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(HarcamaDbContext))]
    partial class HarcamaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WinFormsApp1.Models.Harcama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FisNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HarcamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PersonelId")
                        .HasColumnType("int");

                    b.Property<int?>("SubeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.HasIndex("SubeId");

                    b.ToTable("Harcamalar");
                });

            modelBuilder.Entity("WinFormsApp1.Models.HarcamaDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HarcamaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("HarcamaId");

                    b.ToTable("HarcamaDetaylari");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdiSoyadi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubeId")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubeId");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Sube", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubeAdi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Subeler");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Harcama", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelId");

                    b.HasOne("WinFormsApp1.Models.Sube", "Sube")
                        .WithMany()
                        .HasForeignKey("SubeId");

                    b.Navigation("Personel");

                    b.Navigation("Sube");
                });

            modelBuilder.Entity("WinFormsApp1.Models.HarcamaDetay", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Harcama", "Harcama")
                        .WithMany("HarcamaDetaylari")
                        .HasForeignKey("HarcamaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Harcama");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Personel", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Sube", "Sube")
                        .WithMany("Personeller")
                        .HasForeignKey("SubeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sube");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Harcama", b =>
                {
                    b.Navigation("HarcamaDetaylari");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Sube", b =>
                {
                    b.Navigation("Personeller");
                });
#pragma warning restore 612, 618
        }
    }
}
