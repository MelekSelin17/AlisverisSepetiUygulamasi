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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme3
{
     
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Classlardandan nesne olusturdum.
        sepet Sepet = new sepet();
        urun urunn = new urun();
        laptop laptopp = new laptop(13, (1366 * 768), 16, 1, 6);
        ledTv ledTvv = new ledTv(20, (1366 * 768));
        cepTel cepTell = new cepTel(128, 6, 6);
        buzdolabi buzdolabii = new buzdolabi(600, "AA");
       
        
        int sayac1 = 0;
        int sayac2 = 0;
        int sayac3= 0;
        int sayac4 = 0;
        bool check = true;
        //Listbox1'e secilen adetlerin sayisini yazdirdim.
        public void listboxlaraYazdirma()
        {
            int artis_degeri = Convert.ToInt32(numericUpDown1.Value);
            sayac1 += artis_degeri;
            if (sayac1 != 0)
                listBox1.Items.Add(sayac1);
           
            int artisDegeri = Convert.ToInt32(numericUpDown2.Value);
            sayac2 += artisDegeri;
            if (sayac2 != 0)
                listBox1.Items.Add(sayac2);
          
            int artisDegerii = Convert.ToInt32(numericUpDown3.Value);
            sayac3 += artisDegerii;
            if (sayac3 != 0)
                listBox1.Items.Add(sayac3);
       

            int artisDegeriii = Convert.ToInt32(numericUpDown4.Value);
            sayac4 += artisDegeriii;
            if (sayac4 != 0)
                listBox1.Items.Add(sayac4);
           
        }
        //Stogu azalttim.
        public void stokAzalt()
        {

            ledTvv.stokAdedi = ledTvv.stokAdedi - sayac1;
            label14.Text = ledTvv.stokAdedi.ToString();

            laptopp.stokAdedi = laptopp.stokAdedi - sayac2;
            label16.Text = laptopp.stokAdedi.ToString();

            buzdolabii.stokAdedi = buzdolabii.stokAdedi - sayac3;
            label18.Text = buzdolabii.stokAdedi.ToString();

            cepTell.stokAdedi = cepTell.stokAdedi - sayac4;
            label20.Text = cepTell.stokAdedi.ToString();
        }
        //Listbox2'ye secilen ürünleri yazdirdim.
        public void sepeteEkle()
        {


            if (numericUpDown1.Value > 0)
            {
                listBox2.Items.Add("LedTv");
            }
            if (numericUpDown2.Value > 0)
            {
                listBox2.Items.Add("Laptop");
            }
            if (numericUpDown3.Value > 0)
            {
                listBox2.Items.Add("Buzdolabi");
            }
            if (numericUpDown4.Value > 0)
            {
                listBox2.Items.Add("Cep Telefonu");
            }
        }
        //listbox3'e secilen ürünlerin hesaplanan kdvli fiyatlarini yazdirdim.
        public void kdvUygula()
        {


            ledTvv.secilenAdet = Convert.ToInt32(numericUpDown1.Value);
            laptopp.secilenAdet = Convert.ToInt32(numericUpDown2.Value);
            buzdolabii.secilenAdet = Convert.ToInt32(numericUpDown3.Value);
            cepTell.secilenAdet = Convert.ToInt32(numericUpDown4.Value);


            if (ledTvv.secilenAdet > 0 && ledTvv.stokAdedi > ledTvv.secilenAdet)
            {
                listBox3.Items.Add(ledTvv.kdvUygulaLed());
            }
            if (laptopp.secilenAdet > 0 && laptopp.stokAdedi > laptopp.secilenAdet)
            {
                listBox3.Items.Add(laptopp.kdvUygulaLaptop());
            }
            if (buzdolabii.secilenAdet > 0 && buzdolabii.stokAdedi > laptopp.secilenAdet)
            {
                listBox3.Items.Add(buzdolabii.kdvUygulabuzdolabi());
            }
            if (cepTell.secilenAdet > 0 && cepTell.stokAdedi > cepTell.secilenAdet)
            {
                listBox3.Items.Add(cepTell.kdvUygulacepTel());
            }
        }
        //Kdvli toplam fiyati listbox3deki değerleri toplayarak buldum.
        public void kdvliToplam()
        {
            double toplam = 0;
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox3.Items[i]);
            }
            label25.Text = Convert.ToString(toplam);
        }
        //Buton1'e basilinca fonksiyonlarin cagrilmasini sagladim.
        private void button1_Click(object sender, EventArgs e)
        {
            if (check)//Buton2'ye basmadan buton1'e tekrar basılmasını engelleyen kontrol sistemi.
            {
                sepeteEkle();
                listboxlaraYazdirma();
                kdvUygula();
                kdvliToplam();
                stokAzalt();
                sepet sepett = new sepet();
            
                check = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //labellara rastgele alınan stok adetlerini yazdirdim.
            label14.Text = ledTvv.stokAdedi.ToString();
            label16.Text = laptopp.stokAdedi.ToString();
            label18.Text = buzdolabii.stokAdedi.ToString();
            label20.Text = cepTell.stokAdedi.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
    
      

        }
        //Buton2'ye basınca stoklari yenileyen fonksiyonu yazdim.
        private void stogaEkle()
        {
            ledTvv.stokAdedi = ledTvv.stokAdedi + sayac1;
            label14.Text = ledTvv.stokAdedi.ToString();

            laptopp.stokAdedi = laptopp.stokAdedi + sayac2;
            label16.Text = laptopp.stokAdedi.ToString();

            buzdolabii.stokAdedi = buzdolabii.stokAdedi + sayac3;
            label18.Text = buzdolabii.stokAdedi.ToString();

            cepTell.stokAdedi = cepTell.stokAdedi + sayac4;
            label20.Text = cepTell.stokAdedi.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            //Listboxlari temizledim.
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            stogaEkle();
            //Sayaclari sifirladim.
            sayac1 = 0;
            sayac2 = 0;
            sayac3 = 0;
            sayac4 = 0;

            label25.Text = string.Empty;
            //Adet secimi icin numericDown'lari sifiradim.
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;

            check = true;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
