/**************************************************************
**
**    Sakarya Üniversitesi 
**    Bilgisayar ve Bilişim Bilimleri Fakültesi
**    Bilgisayar Mühendisligi Bölümü
**    Nesneye Dayali Programlama Dersi
**    2019-2020 Bahar Donemi
**    2.Odev
**
**   ADI: Melek Selin Uysal
**   Numara: B191210035
**   Sinif: 1/C
**
***************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListBox listBox1 = new ListBox();
        ListBox listBox2 = new ListBox();
        TextBox textBox3 = new TextBox();
        TextBox textBox4 = new TextBox();
        Label label3 = new Label(); //nesne olusturdum
        Label label4 = new Label();
        Label label5 = new Label();

        private void button1_Click(object sender, EventArgs e)
        {
            //ListBoxların içlerini temizler.
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            this.Controls.Remove(listBox1);//aynı yere tekrar kontrollerin eklenmesi engelleniyor.
            this.Controls.Remove(listBox2);
            this.Controls.Remove(label3);
            this.Controls.Remove(label4);
            this.Controls.Remove(label5);
            this.Controls.Remove(textBox3);
            this.Controls.Remove(textBox4);


            //buton1'e tıkladığımda nesnelerin belirli özelliklerle olusturulmasını saglayan fonksiyonların kodları
            label3.Location = new System.Drawing.Point(382, 33);//lokasyon
            label3.Name = "Label3"; //isim
            label3.Size = new System.Drawing.Size(14, 13); //boyut
            label3.BackColor = System.Drawing.Color.White; //iç kisim rengi
            label3.ForeColor = System.Drawing.Color.Black; // dis kisim rengi
            Controls.Add(label3); //denetim koleksiyonuna ekler
            label3.Text = "X"; //girilen metin


  
            label4.Location = new System.Drawing.Point(548, 33);
            label4.Name = "Label4";
            label4.Size = new System.Drawing.Size(14, 13);
            label4.BackColor = System.Drawing.Color.White;
            label4.ForeColor = System.Drawing.Color.Black;
            Controls.Add(label4);
            label4.Text = "Y";

        
            label5.Location = new System.Drawing.Point(200, 202);
            label5.Name = "Label5";
            label5.Size = new System.Drawing.Size(120, 13);
            label5.BackColor = System.Drawing.Color.White;
            label5.ForeColor = System.Drawing.Color.Black;
            Controls.Add(label5);
            label5.Text = "CarpanlarininToplami";

          
            listBox1.Location = new System.Drawing.Point(342, 63);
            listBox1.Name = "ListBox1";
            listBox1.Size = new System.Drawing.Size(120, 95);
            listBox1.BackColor = System.Drawing.Color.White;
            listBox1.ForeColor = System.Drawing.Color.Black;
            Controls.Add(listBox1);


            listBox2.Location = new System.Drawing.Point(507, 63);
            listBox2.Name = "ListBox2";
            listBox2.Size = new System.Drawing.Size(120, 95);
            listBox2.BackColor = System.Drawing.Color.White;
            listBox2.ForeColor = System.Drawing.Color.Black;
            Controls.Add(listBox2);

        
            textBox3.Location = new System.Drawing.Point(342, 195);
            textBox3.Name = " textBox3";
            textBox3.Size = new System.Drawing.Size(100, 20);
            textBox3.BackColor = System.Drawing.Color.White;
            textBox3.ForeColor = System.Drawing.Color.Black;
            Controls.Add(textBox3);


            textBox4.Location = new System.Drawing.Point(507, 195);
            textBox4.Name = " textBox4";
            textBox4.Size = new System.Drawing.Size(100, 20);
            textBox4.BackColor = System.Drawing.Color.White;
            textBox4.ForeColor = System.Drawing.Color.Black;
            Controls.Add(textBox4);

            int x, y;
            x = Convert.ToInt32(textBox1.Text); //kullanicinin textBoxlara sayi girmesini saglayan fonksiyon
            y = Convert.ToInt32(textBox2.Text);

            int toplamX = 0;
            int toplamY = 0;
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)  // x'in carpanlarini buldum
                {
                    toplamX = toplamX + i; //toplama ekledim
                    listBox1.Items.Add(i); //carpanlari listBox'a yazdirdim. 
                }
            }
            for (int i = 1; i < y; i++)
            {
                if (y % i == 0)
                {
                    toplamY = toplamY + i;
                    listBox2.Items.Add(i);
                }
            }

            textBox3.Text = toplamX.ToString(); //Toplami textBox'a yazdirdim.
            textBox4.Text = toplamY.ToString();
         
        }


        private void button2_Click_1(object sender, EventArgs e)
        { 
            //Cikis yapmak için kullanilan fonksiyon
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Arkadas Sayilar";
        }
    }
}
