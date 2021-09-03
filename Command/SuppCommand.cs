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
    public partial class SuppCommand : Form
    {
        public SuppCommand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code = int.Parse(textBox1.Text);
            MainForm.gestC.supp(code);
        }
    }
}
