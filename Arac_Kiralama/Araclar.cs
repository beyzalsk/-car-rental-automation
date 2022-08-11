using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class Araclar : Form
    {
        public Araclar()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {

            KAnasayfa aracListe = new KAnasayfa();
            aracListe.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand km1 = new SqlCommand();
            km1.CommandText = "SELECT Marka FROM Markalar";
            km1.Connection = bağlama;

            SqlDataAdapter sql1 = new SqlDataAdapter(km1);
            DataTable tble1 = new DataTable();
            sql1.Fill(tble1);

            dataGridView1.DataSource = tble1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand km2 = new SqlCommand();
            km2.CommandText = "SELECT  Markalar.Marka ,Modeller.Model FROM Modeller INNER JOIN Markalar on Markalar.M_İd= Modeller.Marka";
            km2.Connection = bağlama;

            SqlDataAdapter sql2 = new SqlDataAdapter(km2);
            DataTable tble2 = new DataTable();
            sql2.Fill(tble2);


            dataGridView1.DataSource = tble2;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand km3 = new SqlCommand();
            km3.CommandText = "SELECT Renk FROM Renkler";
            km3.Connection = bağlama;

            SqlDataAdapter sql3 = new SqlDataAdapter(km3);
            DataTable tble3 = new DataTable();
            sql3.Fill(tble3);


            dataGridView1.DataSource = tble3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand km4 = new SqlCommand();
            km4.CommandText = "SELECT  Modeller.Model, Renkler.Renk,Fiyatlar.Günlük , Fiyatlar.Aylık FROM Fiyatlar INNER JOIN Modeller on Modeller.Mo_İd= Fiyatlar.Model INNER JOIN Renkler on Renkler.R_İd=Fiyatlar.Renk";
            km4.Connection = bağlama;

            SqlDataAdapter sql4 = new SqlDataAdapter(km4);
            DataTable tble4= new DataTable();
            sql4.Fill(tble4);


            dataGridView1.DataSource = tble4;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand km5 = new SqlCommand();
            km5.CommandText =  "SELECT Modeller.Model, Renkler.Renk,Arac.Plaka,Arac.Kişi_Sayı,Arac.Vites_Türü, Arac.Yakıt_Türü from Arac  INNER JOIN Modeller on Modeller.Mo_İd = Arac.Model INNER JOIN Renkler on Renkler.R_İd = Arac.Renk";
            km5.Connection = bağlama;

            SqlDataAdapter sql5 = new SqlDataAdapter(km5);
            DataTable tble5 = new DataTable();
            sql5.Fill(tble5);


            dataGridView1.DataSource = tble5;





        }
    }
}
