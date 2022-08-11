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
    public partial class AdminG : Form
    {
        SqlDataReader ad;
       

        public AdminG()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string isim = aisim.Text;
            string sifre = asifre.Text;
            SqlCommand admn = new SqlCommand();
            bağlama.Open();
            admn.Connection = bağlama;
            admn.CommandText = "Select*from admin where isim= '" + aisim.Text +
                "' And Şifre='" + asifre.Text + "'";
            ad = admn.ExecuteReader();
            if (ad.Read())
            {
                MessageBox.Show("Tebrikler giriş başarılı");
                aisim.Clear();
                asifre.Clear();
                this.Close();
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.ShowDialog();
                
            }
            else {

                MessageBox.Show("Hatalı Giriş Tekrar Deneyiniz");
              
                
            
            }
            bağlama.Close();
           
            
        }
    }
}
