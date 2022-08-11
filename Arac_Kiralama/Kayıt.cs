using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Arac_Kiralama
{
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        private void button2_Click(object sender, EventArgs e)
        {


            bağlama.Open();
            string kyt = "insert into Kullanıcı (EPosta,KSifre) values (@EPosta,@KSifre)";
            SqlCommand kytt = new SqlCommand(kyt, bağlama);
            kytt.Parameters.AddWithValue("@EPosta", mail.Text);
            kytt.Parameters.AddWithValue("@KSifre", sifre.Text);
           
            kytt.ExecuteNonQuery();
            mail.Clear();
            sifre.Clear();

            MessageBox.Show("Kayıt İşleminiz Onaylanmıştır");


        }

    }





    }


