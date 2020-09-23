/****************************************************
 **
 **
 **  Adi Soyadi: Melek Selin Uysal
 **  Numara: B191210035
 **  Grubu: 1/C
 **
 **
 **
 ***************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace deneme3
{
    //Urun sinifi ve özelliklerini olusturdum.
    public class urun
    { 
        public string ad;
        public string marka;
        public string model;
        public string ozellik;
        public int stokAdedi;
        public double hamFiyat;
        public int secilenAdet;
        public urun()
        {

        }
    }
    //Urun sınıfından buzdolabina miras aldım.
    public class buzdolabi : urun
    {
        public double icHacim;
        public string enerjiSinifi;

        public buzdolabi(double icHacimm, string enerjiSinifii)
        {
            icHacim = icHacimm;
            enerjiSinifi = enerjiSinifii;
            Random rastgele = new Random(50); 
            //Stok adedini rastgele olusturdum.
            for (int i = 1; i < 100; i++)
            {
                int sayi = rastgele.Next(1, 100);
                stokAdedi = sayi;
            }
            //Ozellikler
            ad = "Buzdolabi";
            marka = "Bosch";
            model = "B1881";
            ozellik = "Kapasitesi genis";
        }
        //Buzdolabi için kdvli fiyat buldum.
        public double kdvUygulabuzdolabi()
        {
            hamFiyat = 3500;
            double kdvliFiyat = hamFiyat * secilenAdet * (1.05);
            return kdvliFiyat;
        }

    }
    
    public class ledTv : urun
    {
        public int ekranBoyutu;
        public double cozunurluk;
        public int stokadetii;
        public ledTv(int ekranBoyutuu, double cozunurlukk)
        {
            ekranBoyutu = ekranBoyutuu;
            cozunurluk = cozunurlukk;

            
            Random rastgele = new Random(40);

            for (int i = 1; i < 100; i++)
            {
                int sayi = rastgele.Next(1, 100);
                stokAdedi= sayi;

            }
            ad = "ledTv";
            marka = "lg";
            model = "55SM8000";
            ozellik = "Antrasit";
        }
        
        //Ledtv için kdvli fiyat buldum.
        public double kdvUygulaLed()
        {
            hamFiyat = 4000;
            double kdvliFiyat = hamFiyat * secilenAdet * (1.18);
            return kdvliFiyat;
        }
    }
    public class laptop : urun
    {
        public int ekranBoyutu;
        public double ekranCozunurlugu;
        public int dahiliHafiza;
        public int ramKapasitesi;
        public int pilGucu;

        public laptop(int ekranBoyutuu, double ekranCozunurluguu, int dahiliHafizaa, int ramKapasitesii, int pilGucuu)
        {
            ekranBoyutu = ekranBoyutuu;
            ekranCozunurlugu = ekranCozunurluguu;
            dahiliHafiza = dahiliHafizaa;
            ramKapasitesi = ramKapasitesii;
            pilGucu = pilGucuu;
           Random rastgele = new Random(30);

            for (int i = 1; i < 100; i++)
            {
                int sayi = rastgele.Next(1,100);
                stokAdedi = sayi;
            }
            ad = "Bilgisayar";
            marka = "Asus";
            model = " G531GT-BQ429";
            ozellik = "hizli";
        }
        //Laptop için kdvli fiyat buldum.
        public double kdvUygulaLaptop()
        {
            hamFiyat = 6000;
            double kdvliFiyat = hamFiyat * secilenAdet * (1.15);
            return kdvliFiyat;
        }
    }

    public class cepTel : urun
    {
        public int dahiliHafiza;
        public int ramKapasitesi;
        public int pilGucu;

        public cepTel(int dahiliHafizaa, int ramKapasitesii, int pilGucuu)
        {
            dahiliHafiza = dahiliHafizaa;
            ramKapasitesi = ramKapasitesii;
            pilGucu = pilGucuu;
            Random rastgele = new Random();

            for (int i = 1; i < 100; i++)
            {
                int sayi = rastgele.Next(1, 100);
                stokAdedi = sayi;
            }
            ad = "telefon";
            marka = "iphone";
            model = "xr";
            ozellik ="Su gecirmez";
        }
        //Telefon icin kdvli fiyat buldum.
        public double kdvUygulacepTel()
        {
            hamFiyat = 2500;
            double kdvliFiyat = hamFiyat * secilenAdet * (1.2);
            return kdvliFiyat;
        }

    }
    //Sepete urun ekleyip cikardim.
    public class sepet:urun
    {
      
        public void sepeteUrunEkle(urun urn)
        {


            for (int i = 0; i < urn.secilenAdet; i++)
            {
                urn.stokAdedi--;
            }


        }

        public void stogaGeriEkle(urun urn)
        {

            for (int i = 0; i < urn.secilenAdet; i++)
            {
                urn.stokAdedi++;
            }

        }

    }
}
    
 
     
   
