using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class KAnasayfa : Form
    {
        public KAnasayfa()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Araclar araclar = new Araclar();
            araclar.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kiralama kiralama = new Kiralama();
            kiralama.ShowDialog();  
        }

        private void AracListe_Load(object sender, EventArgs e)
        {

        }

       
    }
}
