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
    public partial class KiBilgi : Form
    {
        public KiBilgi()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand();
            kmt2.CommandText = "SELECT Müsteri_Bilgi.İsim,Müsteri_Bilgi.Soyisim, Tarih_Müsteri.Model,Tarih_Müsteri.Renk ,Tarih_Müsteri.Alım_Tarihi,Tarih_Müsteri.Veriş_Tarihi FROM Tarih_Müsteri INNER JOIN Müsteri_Bilgi on Müsteri_Bilgi.Ehliyet_No= Tarih_Müsteri.Ehliyet";
            kmt2.Connection = bağlama;

            SqlDataAdapter sql = new SqlDataAdapter(kmt2);
            DataTable table = new DataTable();
            sql.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
