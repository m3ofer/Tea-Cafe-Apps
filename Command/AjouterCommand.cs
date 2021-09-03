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
namespace CAISE
{
    public partial class AjouterCommand : Form
    {
        public AjouterCommand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Command c = new Command();
            c.NumCommand = int.Parse(textBox1.Text);
            c.Date = dateTimePicker1.Text;
            c.Time = dateTimePicker2.Text;
            c.Codeserveur = int.Parse(comboBox1.Text);
            MainForm.gestC.ajouter(c);
        }

        private void AjouterCommand_Load(object sender, EventArgs e)
        {
            String con = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = CaisseThe; Integrated Security = True";
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT code_serveur FROM Serveurs", sqlcon);
                DataTable tbl = new DataTable();
                sqlData.Fill(tbl);
                foreach (DataRow dr in tbl.Rows)
                {
                    comboBox1.Items.Add(dr["code_serveur"].ToString());
                }
                //comboBox1.DataSource = tbl;
                sqlcon.Close();
            }
        }
    }
}
