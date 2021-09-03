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
    public partial class MainForm : Form
    {
        // AccessToDataBase check = new AccessToDataBase();
        internal static GestionServeur gestV = new GestionServeur();
        internal static GestionBoisson gestB = new GestionBoisson();
        internal static GestionRecette gestR = new GestionRecette();
        internal static GestionCommand gestC = new GestionCommand();
        public MainForm()
        {
            InitializeComponent();
            Designe();
            //check.checkDatabaseConection();
        }

        private void Designe()
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
            if (panel5.Visible == true)
                panel5.Visible = false;
            if (panel6.Visible == true)
                panel6.Visible = false;
        }
        private void showsubmenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                hidesubmenu();
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }

        private Form activeform = null;
        private void openform(Form childForm)
        {

            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel7.Controls.Add(childForm);
            panel7.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            DoubleBuffered = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openform(new ListerBoisson());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showsubmenu(panel3);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            showsubmenu(panel6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showsubmenu(panel4);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showsubmenu(panel5);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openform(new AjouterServeur());
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openform(new AjouterCommand());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openform(new ListerCommand());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openform(new AjouterRecette());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openform(new ListerRecette());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openform(new ListerServeur());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openform(new AjouterBoisson());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            openform(new SuppServer());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openform(new SuppBoisson());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openform(new SuppRecette());
        }
    }
}
