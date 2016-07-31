using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otel_Rezervasyon_Sistemi
{
    public partial class OtelRezervasyonSistemi : Form
    {
        public OtelRezervasyonSistemi()
        {
            InitializeComponent();
        }
        //Access bağlantısı için gereken OleDb kodları
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel.accdb; Persist Security Info=False;");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        private void button17_Click(object sender, EventArgs e)
        {

        }
        //odaların boş doluluk kontrolü için, boşsa boş tablosuna doluysa dolu tablosuna yazılsın.
        public void combo()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from Boş";
            OleDbDataReader ODA;
            ODA = komut.ExecuteReader();
            while (ODA.Read())
            {
                cB1.Items.Add(ODA[0].ToString());
            }
            baglanti.Close();
            ODA.Dispose();
            cB1.Sorted = true;
        }
        public void combo2()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from Dolu";
            OleDbDataReader ODA;
            ODA = komut.ExecuteReader();
            while (ODA.Read())
            {
                cB1.Items.Add(ODA[0].ToString());
            }
            baglanti.Close();
            ODA.Dispose();
            cB1.Sorted = true;

        }
        //rezervasyonda hangi oda seçilmişse, seçili odayı kırmızıya dönüştür.
        public void sahayaz()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from Rezervasyon";
            OleDbDataReader ODA;
            ODA = komut.ExecuteReader();
            while (ODA.Read())
            {
                switch (ODA[11].ToString())
                {
                    case "101":
                        {
                            btn101.Text = "101";
                            btn101.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "102":
                        {
                            btn102.Text = "102";
                            btn102.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "103":
                        {
                            btn103.Text = "103";
                            btn103.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "104":
                        {
                            btn104.Text = "104";
                            btn104.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "105":
                        {
                            btn105.Text = "105";
                            btn105.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "201":
                        {
                            btn201.Text = "201";
                            btn201.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "202":
                        {
                            btn202.Text = "202";
                            btn202.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "203":
                        {
                            btn203.Text = "203";
                            btn203.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "Suit-1":
                        {
                            btns1.Text = "Suit-1";
                            btns1.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "Suit-2":
                        {
                            btns2.Text = "Suit-2";
                            btns2.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "301":
                        {
                            btn301.Text = "301";
                            btn301.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "302":
                        {
                            btn302.Text = "302";
                            btn302.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "303":
                        {
                            btn303.Text = "303";
                            btn303.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "Suit-3":
                        {
                            btns3.Text = "Suit-3";
                            btns3.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "Kral-1":
                        {
                            btnk1.Text = "Kral-1";
                            btnk1.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "401":
                        {
                            btn401.Text = "401";
                            btn401.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "402":
                        {
                            btn402.Text = "402";
                            btn402.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "403":
                        {
                            btn403.Text = "403";
                            btn403.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "Kral-2":
                        {
                            btnk2.Text = "Kral-2";
                            btnk2.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "Kral-3":
                        {
                            btnk3.Text = "Kral-3";
                            btnk3.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                }
            }
            baglanti.Close();
            ODA.Dispose();

        }
        //rezervasyonda hangi kayıt silinmişse, o odayı tekrar yeşil yap
        public void sahasil()
        {

            switch (textBox9.Text)
            {

                case "101":
                    {
                        btn101.Text = "101";
                        btn101.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "102":
                    {
                        btn102.Text = "102";
                        btn102.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "103":
                    {
                        btn103.Text = "103";
                        btn103.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "104":
                    {
                        btn104.Text = "104";
                        btn104.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "105":
                    {
                        btn105.Text = "105";
                        btn105.BackColor = System.Drawing.Color.Green;
                        break;
                    }

                case "201":
                    {
                        btn201.Text = "201";
                        btn201.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "202":
                    {
                        btn202.Text = "202";
                        btn202.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "203":
                    {
                        btn203.Text = "203";
                        btn203.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "Suit-1":
                    {
                        btns1.Text = "Suit-1";
                        btns1.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "Suit-2":
                    {
                        btns2.Text = "Suit-2";
                        btns2.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "301":
                    {
                        btn301.Text = "301";
                        btn301.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "302":
                    {
                        btn302.Text = "302";
                        btn302.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "303":
                    {
                        btn303.Text = "303";
                        btn303.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "Suit-3":
                    {
                        btns3.Text = "Suit-3";
                        btns3.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "Kral-1":
                    {
                        btnk1.Text = "Kral-1";
                        btnk1.BackColor = System.Drawing.Color.Green;
                        break;
                    }

                case "401":
                    {
                        btn401.Text = "401";
                        btn401.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "402":
                    {
                        btn402.Text = "402";
                        btn402.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "403":
                    {
                        btn403.Text = "403";
                        btn403.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "Kral-2":
                    {
                        btnk2.Text = "Kral-2";
                        btnk2.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "Kral-3":
                    {
                        btnk3.Text = "Kral-3";
                        btnk3.BackColor = System.Drawing.Color.Green;
                        break;
                    }
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //ödeme şekli ve odalarımızın listesini, seçilen odanın rengini, listele komutumuzu tanımladığımız ana kod
        private void OtelRezervasyonSistemi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet.Rezervasyon' table. You can move, or remove it, as needed.
            //this.rezervasyonTableAdapter.Fill(this.otelDataSet.Rezervasyon);
            comboBox2.Items.Add("Nakit");
            comboBox2.Items.Add("Kredi Kartı");
            listele();
            combo();
            sahayaz();
        }
        //veritabanındaki tün kayıtları listeleyen fonksiyon
        void listele()
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("select * from Rezervasyon", baglanti);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        //rezervasyon kaydet butonu
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {

                baglanti.Open();
                //combo();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT Into Rezervasyon (musteri_ad, musteri_soyad, sehir, telefon, ulke, eposta, giris_tarihi, cikis_tarihi, yetiskin_sayi, cocuk_sayi, oda) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + dateTimePicker2.Value + "', '" + dateTimePicker1.Value + "','" + textBox7.Text + "','" + textBox8.Text + "','" + cB1.Text + "')";
                komut.ExecuteNonQuery();
                komut.CommandText = "INSERT INTO Dolu VALUES ('" + cB1.Text + "') ";
                komut.ExecuteNonQuery();
                komut.CommandText = "DELETE from Boş WHERE bos_odalar='" + cB1.Text + "'";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                cB1.Items.Clear();
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                textBox4.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear();
                textBox8.Clear();
                combo();
                label23.Text = "";
                cB1.Text = "";
                comboBox2.Text = "";
                sahayaz();

                MessageBox.Show("Kayıt tamamlandı.");
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!");
            }
        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }
        //oda numarası girilen kaydı silen buton
        private void sil_btn_Click(object sender, EventArgs e)
        {
            try 
            {
 
              DialogResult cevap;
 
              cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
 
              if (cevap == DialogResult.Yes) 
            {
                sahasil();
                komut.Connection = baglanti;
                baglanti.Open();
                komut.CommandText = "delete from Rezervasyon where oda='" + textBox9.Text + "'";
                komut.ExecuteNonQuery();
                komut.CommandText = "INSERT INTO Boş(bos_odalar) VALUES ('" + textBox9.Text + "') ";
                komut.ExecuteNonQuery();
                komut.CommandText = "DELETE from Dolu WHERE dolu_odalar='" + textBox9.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                cB1.Items.Clear();
                //cB1.Items.Clear();
                cB1.Text = "";
                combo();
                textBox9.Clear();
                ds.Clear();
                listele(); 
                } 
           } 
               catch (Exception hata) 
           { 
               MessageBox.Show(hata.Message);  
             }
             
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        //Butonlara basıldığında silinecek odayı gösterir.

        private void btn301_Click(object sender, EventArgs e)
        {
            textBox9.Text = "301";
        }

        private void btn302_Click(object sender, EventArgs e)
        {
            textBox9.Text = "302";
        }

        private void btn303_Click(object sender, EventArgs e)
        {
            textBox9.Text = "303";
        }

        private void btns3_Click(object sender, EventArgs e)
        {
            textBox9.Text = "Suit-3";
        }

        private void btnk1_Click(object sender, EventArgs e)
        {
            textBox9.Text = "Kral-1";
        }

        private void btn401_Click(object sender, EventArgs e)
        {
            textBox9.Text = "401";
        }

        private void btn402_Click(object sender, EventArgs e)
        {
            textBox9.Text = "402";
        }

        private void btn403_Click(object sender, EventArgs e)
        {
            textBox9.Text = "403";
        }

        private void btnk2_Click(object sender, EventArgs e)
        {
            textBox9.Text = "Kral-2";
        }

        private void btnk3_Click(object sender, EventArgs e)
        {
            textBox9.Text = "Kral-3";
        }

        private void btns2_Click(object sender, EventArgs e)
        {
            textBox9.Text = "Suit-2";
        }

        private void btns1_Click(object sender, EventArgs e)
        {
            textBox9.Text = "Suit-1";
        }

        private void btn203_Click(object sender, EventArgs e)
        {
            textBox9.Text = "203";
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            textBox9.Text = "202";
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            textBox9.Text = "201";
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            textBox9.Text = "101";
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            textBox9.Text = "102";
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            textBox9.Text = "103";
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            textBox9.Text = "104";
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            textBox9.Text = "105";
        }
        //hakkımızda kısmında grup tanıtımı yaptık
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projede Emeği Geçenler \n \n Alper GEDİK \n Batuhan SÜERSAN \n Betül ASLAN \n Bulut ÇOLAK \n Rana SARIKAYA ");
        }
    }
}
