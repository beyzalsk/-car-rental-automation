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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bağlama.Open();
            string ekle = "insert into Markalar (Marka) values (@Marka)";
            SqlCommand ekmt = new SqlCommand(ekle, bağlama);
            ekmt.Parameters.AddWithValue("@Marka", marka.Text);
            ekmt.ExecuteNonQuery();
            MessageBox.Show("Markanız Eklenmiştir");
            bağlama.Close();
        }

        private void ekle2_Click(object sender, EventArgs e)
        {
            bağlama.Open();
            string ekle1 = "insert into Modeller (Marka,Model) values (@Marka,@Model)";
            SqlCommand ekmt1 = new SqlCommand(ekle1, bağlama);
            ekmt1.Parameters.AddWithValue("@Marka", textma.Text);
            ekmt1.Parameters.AddWithValue("@Model", model.Text);
            ekmt1.ExecuteNonQuery();
            MessageBox.Show("Modeliniz Eklenmiştir");
            bağlama.Close();
        }

        private void ekle3_Click(object sender, EventArgs e)
        {
            bağlama.Open();
            string ekle2 = "insert into Renkler (Renk) values (@Renk)";
            SqlCommand ekmt2 = new SqlCommand(ekle2, bağlama);
            ekmt2.Parameters.AddWithValue("@Renk", renk.Text);
            ekmt2.ExecuteNonQuery();
            MessageBox.Show("Yeni Renginiz Eklenmiştir");
            bağlama.Close();

        }

        private void ekle4_Click(object sender, EventArgs e)
        {
            bağlama.Open();
            string ekle3 = "insert into arac (Model,Renk,Plaka,Kişi_Sayı,Vites_Türü, Yakıt_Türü) values (@Model,@Renk,@Plaka,@Kişi_Sayı,@Vites_Türü, @Yakıt_Türü)";
            SqlCommand ekmt3 = new SqlCommand(ekle3, bağlama);
            ekmt3.Parameters.AddWithValue("@Model", mlkk.Text.ToString());
            ekmt3.Parameters.AddWithValue("@Renk", mdll.Text.ToString());
            ekmt3.Parameters.AddWithValue("@Plaka", plkk.Text);
            ekmt3.Parameters.AddWithValue("@Kişi_Sayı", kss.Text);
            ekmt3.Parameters.AddWithValue("@Vites_Türü", vtss.Text);
            ekmt3.Parameters.AddWithValue("@Yakıt_Türü", yktt.Text);
            ekmt3.ExecuteNonQuery();
            MessageBox.Show("Araç Bilgileriniz Eklenmiştir");
            bağlama.Close();



        }

       
        public void Markaa (){
            bağlama.Open();
            string getir = "Select*from Markalar";
            SqlCommand ket = new SqlCommand(getir, bağlama);
            SqlDataAdapter ad = new SqlDataAdapter(ket);
            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bağlama.Close();

        }
        public void Renkee()
        {
            bağlama.Open();
            SqlCommand kmt2 = new SqlCommand();
            kmt2.CommandText = "SELECT * FROM Renkler ";
            kmt2.Connection = bağlama;

            SqlDataAdapter sql = new SqlDataAdapter(kmt2);
            DataTable table = new DataTable();
            sql.Fill(table);

            datarenk.DataSource = table;

            bağlama.Close();
        }
        public void Modell() {
            bağlama.Open();
            string getir = "Select Mo_İd, Model from Modeller";
            SqlCommand ket = new SqlCommand(getir, bağlama);
            SqlDataAdapter ad = new SqlDataAdapter(ket);
            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);
            datamodel.DataSource = dataTable;
            bağlama.Close();
        }

      

        private void AracEkle_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Markaa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modell();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Renkee();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Markaa();
        }

        private void datarenk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Markaa();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bağlama.Open();
            string ekle4 = "insert into Fiyatlar (Model,Renk,Günlük,Aylık) values (@Model,@Renk,@Günlük,@Aylık)";
            SqlCommand ekmt4 = new SqlCommand(ekle4, bağlama);
            ekmt4.Parameters.AddWithValue("@Model", textm.Text);
            ekmt4.Parameters.AddWithValue("@Renk", textr.Text);
            ekmt4.Parameters.AddWithValue("@Günlük", textg.Text);
            ekmt4.Parameters.AddWithValue("@Aylık", texta.Text);
            ekmt4.ExecuteNonQuery();
            bağlama.Close();

        }
    }
}
