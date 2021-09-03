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
using CAISE.Main_Classes;

namespace CAISE
{
    public partial class ListerBoisson : Form
    {
        String con = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = CaisseThe; Integrated Security = True";
        public ListerBoisson()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListerBoisson_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Boissons", sqlcon);
                DataTable tbl = new DataTable();
                sqlData.Fill(tbl);
                dataGridView1.DataSource = tbl;
                sqlcon.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Boissons where code_boisson="+ textBox1.Text, sqlcon);
                DataTable tbl = new DataTable();
                sqlData.Fill(tbl);
                dataGridView1.DataSource = tbl;
                sqlcon.Close();
            }
        }
    }
}
