﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazılımSınamaFinalProje
{
    public partial class TeknikKart : MetroFramework.Forms.MetroForm
    {
        public TeknikKart()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = NitelikTeknikKart; Integrated Security = True");
        private void TeknikKart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            
            SqlCommand komut2 = new SqlCommand("insert into Tasks (UserID,KartNo,Tarih,TahminiTarih,GercekletigiTarih,Aciklama,notlar) values('"+label5.Text+"','" + txtKartNo.Text + "','" + txtTarih.Text + "','" + txtTahminiSüre.Text + "','" + txtGerceklesenSüre.Text + "','" + txtİsAciklama.Text + "','" + txtNot.Text + "')", baglan);
            komut2.ExecuteNonQuery();
          
            if (txtTarih1.Text != "")
            {
                SqlCommand komut4 = new SqlCommand("insert into Durumlar (UserID,Tarih,Durum,Yapılacakİs,Aciklama) values('" + textBox2.Text + "','" + txtTarih1.Text + "','" + txtDurum1.Text + "','" + txtYapılacakİs1.Text + "','" + txtAciklama1.Text + "')", baglan);
                komut4.ExecuteNonQuery();
            }
            if (txtTarih2.Text != "")
            {
                SqlCommand komut5 = new SqlCommand("insert into Durumlar (UserID,Tarih,Durum,Yapılacakİs,Aciklama) values('" + textBox3.Text + "','" + txtTarih2.Text + "','" + txtDurum2.Text + "','" + txtYapılacakis2.Text + "','" + txtAciklama2.Text + "')", baglan);
                komut5.ExecuteNonQuery();
            }
            if (txtTarih3.Text != "")
            {
                SqlCommand komut6 = new SqlCommand("insert into Durumlar (UserID,Tarih,Durum,Yapılacakİs,Aciklama) values('" + textBox4.Text + "','" + txtTarih3.Text + "','" + txtDurum3.Text + "','" + txtYapılacakis3.Text + "','" + txtAciklama3.Text + "')", baglan);
                komut6.ExecuteNonQuery();
            }
            if (txtTarih4.Text != "")
            {
                SqlCommand komut7 = new SqlCommand("insert into Durumlar (UserID,Tarih,Durum,Yapılacakİs,Aciklama) values('" + textBox5.Text + "','" + txtTarih4.Text + "','" + txtDurum4.Text + "','" + txtYapılacakis4.Text + "','" + txtAciklama4.Text + "')", baglan);
                komut7.ExecuteNonQuery();
            }
            if (txtTarih5.Text != "")
            {
                SqlCommand komut8 = new SqlCommand("insert into Durumlar (UserID,Tarih,Durum,Yapılacakİs,Aciklama) values('" + textBox6.Text + "','" + txtTarih5.Text + "','" + txtDurum5.Text + "','" + txtYapılacakis5.Text + "','" + txtAciklama5.Text + "')", baglan);
                komut8.ExecuteNonQuery();
            }

            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Todo t = new Todo();
            t.Show();
            this.Hide();
        }
    }
}
