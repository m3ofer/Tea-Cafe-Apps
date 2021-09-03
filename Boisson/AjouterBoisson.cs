using CAISE.Main_Classes;
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
    public partial class AjouterBoisson : Form
    {
        internal static GestionBoisson gestB = new GestionBoisson();
        public AjouterBoisson()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boisson b = new Boisson();
            //float bb = b.Prix;
            b.Code_boisson = int.Parse(textBox1.Text);
            b.Desgnation = textBox2.Text;
            //float.TryParse(textBox3.Text, out bb);
            b.Prix = textBox3.Text;
            b.Quantite = int.Parse(textBox4.Text);
            gestB.ajouter(b);
        }

        private void AjouterBoisson_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("s'il vous plais tu doit seulement saisir les valeur numeric");
            }
        }
    }
}
