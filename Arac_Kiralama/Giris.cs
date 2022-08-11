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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminG adminG = new AdminG();
            adminG.ShowDialog();
            
        }

      

        private void button2_Click_1(object sender, EventArgs e)
        {
            KG kG = new KG();
            kG.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kayıt kayıt = new Kayıt();
            kayıt.ShowDialog();
            

        }
    }
}
