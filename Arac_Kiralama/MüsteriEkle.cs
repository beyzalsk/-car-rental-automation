using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class MüsteriEkle : Form
    {
        public MüsteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DT_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void TC_Click(object sender, EventArgs e)
        {

        }

        private void çk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TL_Click(object sender, EventArgs e)
        {

        }

        private void sil_Click(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            bağlama.Open();
            string ekle = "insert into Müsteri_Bilgi (İsim,Soyisim,Tc_No, Doğum_Tarihi,Cep_Telefonu,Ehliyet_No)values (@İsim,@Soyisim,@Tc_No,@Doğum_Tarihi,@Cep_Telefonu,@Ehliyet_No)";


            SqlCommand ekmt = new SqlCommand(ekle, bağlama);
            
            ekmt.Parameters.AddWithValue("@İsim", isim.Text);
            ekmt.Parameters.AddWithValue("@Soyisim", soyisim.Text);
            ekmt.Parameters.AddWithValue("@Tc_No", ttc.Text);
            ekmt.Parameters.AddWithValue("@Doğum_Tarihi", dtt.Text);
            ekmt.Parameters.AddWithValue("@Cep_Telefonu", tel.Text);
            ekmt.Parameters.AddWithValue("@Ehliyet_No", ehliyet.Text);
            ekmt.ExecuteNonQuery();
            isim.Clear();
            soyisim.Clear();
            ttc.Clear();
            dtt.Clear();
            tel.Clear();
            ehliyet.Clear();

            MessageBox.Show("Müşteri Başarıyla Eklendi");
            bağlama.Close();

        }

       
        public void kayıtgetir()
        {

            bağlama.Open();
            string getir = "Select*from Müsteri_Bilgi";
            SqlCommand ket = new SqlCommand(getir, bağlama);
            SqlDataAdapter ad = new SqlDataAdapter(ket);
            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bağlama.Close();




        }

        
        private void MüsteriEkle_Load(object sender, EventArgs e)
        {
            kayıtgetir();

        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            bağlama.Open();

            SqlCommand sil = new SqlCommand("delete from Müsteri_Bilgi where İsim ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bağlama);
            sil.ExecuteNonQuery();
            MessageBox.Show("Müşteri Başarıyla Silinmiştir");

            bağlama.Close(); ; ;





            
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand kmt3 = new SqlCommand();
            kmt3.CommandText = "SELECT * FROM Müsteri_Bilgi ";
            kmt3.Connection = bağlama;

            SqlDataAdapter sql = new SqlDataAdapter(kmt3);
            DataTable table = new DataTable();
            sql.Fill(table);


            dataGridView1.DataSource = table;
        }
    }
}


