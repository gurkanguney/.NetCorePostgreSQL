using System;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL;
namespace PostgreeDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Database=Deneme;Username=postgres;password=123456");
            //baglanti.Open();
            //Console.WriteLine(baglanti.State);

            Ogrenci yeni = new Ogrenci() { Adi = "Gürkan", Soyadi = "GÜNEY", TCKimlikNo = 1234 };

            Veli veli = new Veli() { Adi = "Nurdan", Soyadi = "Güney", TagID = "1234455", OgrenciId = 1 };

            using (var db = new DatabasePostgre())
            {
                db.Veliler.Add(veli);
                db.SaveChanges();

                foreach (var item in db.Veliler)
                {
                    Console.WriteLine(item.Adi);
                }
            }


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
