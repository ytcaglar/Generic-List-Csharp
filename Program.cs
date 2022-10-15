using System;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> listname = new List<t>();
            
            // Liste oluşturma ve ekleme,

            List<int> sayilar = new List<int>();
            sayilar.Add(5);
            sayilar.Add(10);
            sayilar.Add(22);
            sayilar.Add(33);
            sayilar.Add(55);

            List<string> renkler = new List<string>();
            renkler.Add("Sarı");
            renkler.Add("Kırmızı");
            renkler.Add("Mavi");
            renkler.Add("Siyah");
            renkler.Add("Beyaz");

            // Listelerde eleman sayısını alma - Count()

            System.Console.WriteLine(renkler.Count());
            System.Console.WriteLine(sayilar.Count());

            // Ekrana list elemanlarını yazdırma (foreach)

            foreach(var item in sayilar){
                System.Console.WriteLine(item);
            }

            foreach(var item in renkler){
                System.Console.WriteLine(item);
            }

            sayilar.ForEach(sayi => Console.WriteLine(sayi));
            renkler.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkarma Remove - RemoveAt

            sayilar.Remove(33);
            renkler.Remove("Beyaz");

            sayilar.RemoveAt(3);
            renkler.RemoveAt(3); //index

            sayilar.ForEach(sayi => Console.WriteLine(sayi));
            renkler.ForEach(renk => Console.WriteLine(renk));

            // Liste içinde arama // Contains

            if(sayilar.Contains(22)){
                System.Console.WriteLine("Bu sayı listede var.");
            }
            if(renkler.Contains("Kırmızı")){
                System.Console.WriteLine("Bu renk listede var.");
            }

            // Liste elemanlarını arama BinarySearch(elemanınAdı)

            System.Console.WriteLine(sayilar.BinarySearch(22));
            System.Console.WriteLine(renkler.BinarySearch("Kırmızı"));

            // Diziyi listeye çevirme

            int[] dizi = {8,6,12,52};
            List<int> list = new List<int>(dizi);
            
            // Listeyi temizleme 
            list.Clear();
            System.Console.WriteLine(list.Count());

            // List içinde nesne tutma - Personel bilgileri gibi

            List<Kullanicilar> kullanicilarinListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Tolunay";
            kullanici1.Soyisim = "Çağlar";
            kullanici1.Yas = "25";

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Yusuf";
            kullanici2.Soyisim = "Çağlar";
            kullanici2.Yas = "35";

            kullanicilarinListesi.Add(kullanici1);
            kullanicilarinListesi.Add(kullanici2);

            foreach(var item in kullanicilarinListesi){
                System.Console.WriteLine("Ad: {0}",item.Isim);
                System.Console.WriteLine("Soyad: {0}",item.Soyisim);
                System.Console.WriteLine("Yas: {0}",item.Yas);
            }

            List<Kullanicilar> yeniKulList = new List<Kullanicilar>();
            yeniKulList.Add(new Kullanicilar(){Isim="Hakan",Soyisim="Çağlar",Yas="35"});
            yeniKulList.Add(new Kullanicilar(){Isim="Mehmet",Soyisim="Çağlar",Yas="28"});

            yeniKulList.ForEach(kisi => System.Console.WriteLine("Ad: {0}\nSoyad: {1}\nYaş: {2}",kisi.Isim,kisi.Soyisim,kisi.Yas));


        }
    }

    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private string yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Yas { get => yas; set => yas = value; }
    }
}