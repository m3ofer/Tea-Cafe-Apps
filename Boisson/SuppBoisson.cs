using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAISE
{
    public partial class SuppBoisson : Form
    {
        public SuppBoisson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code = int.Parse(textBox1.Text);
            MainForm.gestB.supp(code);
        }

        private void SuppBoisson_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
