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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = NitelikTeknikKart; Integrated Security = True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut= new SqlCommand("insert into Users (UserName,ProjeID) values('" +metroTextBox1.Text + "','"+metroTextBox3.Text+"')", baglan);
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("Select *from Users", baglan);
            SqlDataReader oku = komut2.ExecuteReader();

            while (oku.Read())
            {
                if (oku["UserName"].ToString() == metroTextBox1.Text)
                {
                    MessageBox.Show("User ID : " + oku["ID"]);
                }
            }

            baglan.Close();
            MessageBox.Show("Kayıt olma işlemi başarı ile tamamlanmıştır");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeknikKart t = new TeknikKart();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Users", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["UserName"].ToString() == metroTextBox1.Text)
                {
                    MessageBox.Show(oku["ID"].ToString());
                    t.label5.Text = oku["ID"].ToString();
                }
            }
            baglan.Close();

            
           
            t.Show();
            
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Projeler (ProjeName) values('" + metroTextBox2.Text + "')", baglan);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("Select *from Projeler", baglan);
            SqlDataReader oku = komut2.ExecuteReader();

            while (oku.Read())
            {
                if (oku["ProjeName"].ToString() == metroTextBox2.Text)
                {
                    MessageBox.Show("Proje ID : "+oku["ID"]);
                }
            }
            baglan.Close();
            MessageBox.Show("Proje oluştuma işlemi başarı ile tamamlanmıştır");
        }
    }
}
