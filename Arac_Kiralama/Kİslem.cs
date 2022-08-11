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
    public partial class Kİslem : Form
    {
        public Kİslem()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand liste = new SqlCommand();
            liste.CommandText = "SELECT * FROM kullanıcı";
            liste.Connection = bağlama;

            SqlDataAdapter sql3 = new SqlDataAdapter(liste);
            DataTable tablo = new DataTable();
            sql3.Fill(tablo);


            dataGridView1.DataSource = tablo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bağlama.Open();

            SqlCommand sil = new SqlCommand("delete from kullanıcı where EPosta='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bağlama);
            sil.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı Başarıyla Silinmiştir");
            bağlama.Close();
        }
    }
}
