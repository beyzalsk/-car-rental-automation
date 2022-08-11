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
    public partial class ALis : Form
    {
        public ALis()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt1 = new SqlCommand();
            kmt1.CommandText = "SELECT Marka FROM Markalar";
            kmt1.Connection = bağlama;

            SqlDataAdapter sql1 = new SqlDataAdapter(kmt1);
            DataTable table1 = new DataTable();
            sql1.Fill(table1);

            dataGridView1.DataSource = table1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand();
            kmt2.CommandText = "SELECT  Markalar.Marka , Modeller.Model FROM Modeller INNER JOIN Markalar on Markalar.M_İd= Modeller.Marka";
            kmt2.Connection = bağlama;

            SqlDataAdapter sql2 = new SqlDataAdapter(kmt2);
            DataTable table2 = new DataTable();
            sql2.Fill(table2);


            dataGridView1.DataSource = table2;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand kmt3 = new SqlCommand();
            kmt3.CommandText = "SELECT Renk FROM Renkler";
            kmt3.Connection = bağlama;

            SqlDataAdapter sql3 = new SqlDataAdapter(kmt3);
            DataTable table3 = new DataTable();
            sql3.Fill(table3);


            dataGridView1.DataSource = table3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand kmt4 = new SqlCommand();
            kmt4.CommandText = "SELECT  Modeller.Model, Renkler.Renk,Fiyatlar.Günlük , Fiyatlar.Aylık FROM Fiyatlar INNER JOIN Modeller on Modeller.Mo_İd= Fiyatlar.Model INNER JOIN Renkler on Renkler.R_İd=Fiyatlar.Renk";
            kmt4.Connection = bağlama;

            SqlDataAdapter sql4 = new SqlDataAdapter(kmt4);
            DataTable table4 = new DataTable();
            sql4.Fill(table4);


            dataGridView1.DataSource = table4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand kmt5 = new SqlCommand();
            kmt5.CommandText = "SELECT Modeller.Model, Renkler.Renk,Arac.Plaka,Arac.Kişi_Sayı,Arac.Vites_Türü,Arac.Yakıt_Türü from Arac  INNER JOIN Modeller on Modeller.Mo_İd = Arac.Model INNER JOIN Renkler on Renkler.R_İd = Arac.Renk ";
            kmt5.Connection = bağlama;

            SqlDataAdapter sql5 = new SqlDataAdapter(kmt5);
            DataTable table5 = new DataTable();
            sql5.Fill(table5);


            dataGridView1.DataSource = table5;
        }
    }
}
