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
    public partial class ListerCommand : Form
    {
        String con = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = CaisseThe; Integrated Security = True";
        public ListerCommand()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListerCommand_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Commandes", sqlcon);
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Commandes where numCom=" + textBox1.Text, sqlcon);
                DataTable tbl = new DataTable();
                sqlData.Fill(tbl);
                dataGridView1.DataSource = tbl;
                sqlcon.Close();
            }
        }
    }
}
