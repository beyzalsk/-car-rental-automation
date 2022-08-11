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
using static System.Windows.Forms.ListView;

namespace Arac_Kiralama
{
    public partial class MListe : Form
    {
        public MListe()
        {
            InitializeComponent();
        }
        SqlConnection bağlama = new SqlConnection("Data Source=DESKTOP-3KG1768;Initial Catalog=Otomasyon;Integrated Security=True");
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt3 = new SqlCommand();
            kmt3.CommandText = "SELECT * FROM Müsteri_Bilgi ";
            kmt3.Connection = bağlama;

            SqlDataAdapter sql = new SqlDataAdapter(kmt3);
            DataTable table = new DataTable();
            sql.Fill(table);


            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
