using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreeDeneme
{

    public class DatabasePostgre : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Veli> Veliler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Database=Ogrenci;Username=postgres;password=123456");
        }

    }

    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int TCKimlikNo { get; set; }

        public List<Veli> Veliler { get; set; }
    }

    public class Veli
    {
        public int VeliId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TagID { get; set; }
        public string GSM { get; set; }

        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }


    }

}
