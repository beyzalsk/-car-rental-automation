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
    public partial class KG : Form
    {
        SqlDataReader oku;
        public KG()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string giris = mail.Text;
            string ssifre = sifre.Text;
            SqlCommand sql = new SqlCommand();
            bağlama.Open();
            sql.Connection = bağlama;
            sql.CommandText = "Select*from Kullanıcı where EPosta='" + mail.Text +
                "' And KSifre= '" + sifre.Text + "'";
            oku = sql.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Başarılı Giriş");
                mail.Clear();
                sifre.Clear();
                this.Close();
                KAnasayfa aracListe = new KAnasayfa();
                aracListe.ShowDialog();
            }

            else {
               
                MessageBox.Show("Hatalı Giriş Bilgilerinizi Tekrar Kontrol Ediniz ");
                
            }
            
            bağlama.Close();
        }
       
        private void KG_Load(object sender, EventArgs e)
        {

        }
    }
}
