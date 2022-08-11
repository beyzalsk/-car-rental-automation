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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            MListe mListe = new MListe();
            mListe.ShowDialog();
        }

        private void ÇK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ME_Click(object sender, EventArgs e)
        {
            MüsteriEkle me = new MüsteriEkle();
            me.ShowDialog();
            
         
        }

        private void AL_Click(object sender, EventArgs e)
        {
            ALis aLis = new ALis();
            aLis.ShowDialog();

        }

        private void Mİ_Click(object sender, EventArgs e)
        {
            KiBilgi mİslem = new KiBilgi();
            mİslem.ShowDialog();
        }

        private void AE_Click(object sender, EventArgs e)
        {
            AracEkle aracEkle = new AracEkle();
            aracEkle.ShowDialog();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Kİslem islem = new Kİslem();
            islem.ShowDialog();

        }
    }
}
