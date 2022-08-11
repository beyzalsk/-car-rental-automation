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
    public partial class Kiralama : Form
    {
        public Kiralama()
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
            string ekleme = "insert into Tarih_Müsteri (Mİsim, MSoyisim,Ehliyet,Model,Renk,Alım_Tarihi,Veriş_Tarihi) values (@Mİsim, @MSoyisim,@Ehliyet,@Model,@Renk,@Alım_Tarihi,@Veriş_Tarihi)";
            SqlCommand ekme = new SqlCommand(ekleme, bağlama);
            ekme.Parameters.AddWithValue("@Mİsim", textis.Text);
            ekme.Parameters.AddWithValue("@MSoyisim", textsi.Text);
            ekme.Parameters.AddWithValue("@Ehliyet",textee.Text );
            ekme.Parameters.AddWithValue("@Model", textm.Text);
            ekme.Parameters.AddWithValue("@Renk", textr.Text);
            ekme.Parameters.AddWithValue("@Alım_Tarihi", krlm.Text);
            ekme.Parameters.AddWithValue("@Veriş_Tarihi", bts.Text);
            ekme.ExecuteNonQuery();
            bağlama.Close();

        }

        private void textee_TextChanged(object sender, EventArgs e)
        {
            if (textee.Text == " ") foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                
            bağlama.Open();
            SqlCommand sql = new SqlCommand("Select * from Müsteri_Bilgi where Ehliyet_No like'"+ textee.Text + "'",bağlama);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                textis.Text = reader["İsim"].ToString();
                textsi.Text = reader[1].ToString();

            }
            bağlama.Close();
            
        }
    }
}
