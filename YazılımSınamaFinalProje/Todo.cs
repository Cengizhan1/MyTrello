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
    public partial class Todo : MetroFramework.Forms.MetroForm
    {
        public Todo()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = NitelikTeknikKart; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Durumlar", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (Convert.ToInt32(oku["Durum"]) == 1)
                {
                    listBox1.Items.Add(oku["Yapılacakİs"].ToString()) ;
                }
                else if (Convert.ToInt32(oku["Durum"]) == 2)
                {
                    listBox2.Items.Add(oku["Yapılacakİs"].ToString());
                }
                else if (Convert.ToInt32(oku["Durum"]) == 3)
                {
                    listBox3.Items.Add(oku["Yapılacakİs"].ToString());
                }
                else if (Convert.ToInt32(oku["Durum"]) == 4)
                {
                    listBox4.Items.Add(oku["Yapılacakİs"].ToString());
                }
                else if (Convert.ToInt32(oku["Durum"]) == 5)
                {
                    listBox5.Items.Add(oku["Yapılacakİs"].ToString());
                }
            }
            baglan.Close();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point nokta = new Point(e.X,e.Y);
            int sira = listBox1.IndexFromPoint(nokta);
            if(e.Button==MouseButtons.Left)
            {
                listBox1.DoDragDrop(listBox1.Items[sira], DragDropEffects.All);
                listBox1.Items.RemoveAt(sira);
            }
            else if (e.Button == MouseButtons.Right)
            {
                int index = this.listBox1.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("Select *from Durumlar", baglan);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        if (oku["Yapılacakİs"].ToString() == listBox1.Items[index].ToString())
                        {
                            MessageBox.Show("Tarih : "+oku["Tarih"]+"\nDurum : "+oku["Durum"]+". seviyede"+"\nAçıklama : "+oku["Aciklama"]+"\nİşi yapacak kullanıcı ID : "+oku["UserID"]);
                        }
                    }
                    baglan.Close();
                }
            }
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listBox2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Point nokta = new Point(e.X, e.Y);
            int sira = listBox2.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {
                listBox2.DoDragDrop(listBox2.Items[sira], DragDropEffects.All);
                listBox2.Items.RemoveAt(sira);
            }
            else if (e.Button == MouseButtons.Right)
            {
                int index = this.listBox2.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("Select *from Durumlar", baglan);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        if (oku["Yapılacakİs"].ToString() == listBox2.Items[index].ToString())
                        {
                            MessageBox.Show("Tarih : " + oku["Tarih"] + "\nDurum : " + oku["Durum"] + ". seviyede" + "\nAçıklama : " + oku["Aciklama"] + "\nİşi yapacak kullanıcı ID : " + oku["UserID"]);
                        }
                    }
                    baglan.Close();
                }
            }
        }

        private void listBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Point nokta = new Point(e.X, e.Y);
            int sira = listBox3.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {
                listBox3.DoDragDrop(listBox3.Items[sira], DragDropEffects.All);
                listBox3.Items.RemoveAt(sira);
            }
            else if (e.Button == MouseButtons.Right)
            {
                int index = this.listBox3.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("Select *from Durumlar", baglan);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        if (oku["Yapılacakİs"].ToString() == listBox3.Items[index].ToString())
                        {
                            MessageBox.Show("Tarih : " + oku["Tarih"] + "\nDurum : " + oku["Durum"] + ". seviyede" + "\nAçıklama : " + oku["Aciklama"] + "\nİşi yapacak kullanıcı ID : " + oku["UserID"]);
                        }
                    }
                    baglan.Close();
                }
            }
        }

        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
            listBox3.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listBox3_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox4_MouseDown(object sender, MouseEventArgs e)
        {
            Point nokta = new Point(e.X, e.Y);
            int sira = listBox4.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {
                listBox4.DoDragDrop(listBox4.Items[sira], DragDropEffects.All);
                listBox4.Items.RemoveAt(sira);
            }
            else if (e.Button == MouseButtons.Right)
            {
                int index = this.listBox4.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("Select *from Durumlar", baglan);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        if (oku["Yapılacakİs"].ToString() == listBox4.Items[index].ToString())
                        {
                            MessageBox.Show("Tarih : " + oku["Tarih"] + "\nDurum : " + oku["Durum"] + ". seviyede" + "\nAçıklama : " + oku["Aciklama"] + "\nİşi yapacak kullanıcı ID : " + oku["UserID"]);
                        }
                    }
                    baglan.Close();
                }
            }
        }

        private void listBox4_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox4_DragDrop(object sender, DragEventArgs e)
        {
            listBox4.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listBox5_MouseDown(object sender, MouseEventArgs e)
        {
            Point nokta = new Point(e.X, e.Y);
            int sira = listBox5.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {
                listBox5.DoDragDrop(listBox5.Items[sira], DragDropEffects.All);
                listBox5.Items.RemoveAt(sira);
            }
            else if (e.Button == MouseButtons.Right)
            {
                int index = this.listBox5.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("Select *from Durumlar", baglan);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        if (oku["Yapılacakİs"].ToString() == listBox5.Items[index].ToString())
                        {
                            MessageBox.Show("Tarih : " + oku["Tarih"] + "\nDurum : " + oku["Durum"] + ". seviyede" + "\nAçıklama : " + oku["Aciklama"] + "\nİşi yapacak kullanıcı ID : " + oku["UserID"]);
                        }
                    }
                    baglan.Close();
                }
            }
        }

        private void listBox5_DragDrop(object sender, DragEventArgs e)
        {
            listBox5.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listBox5_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeknikKart t = new TeknikKart();
            t.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
