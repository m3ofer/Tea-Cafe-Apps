using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAISE.Main_Classes
{
    class AccessToDataBase
    {
        private static SqlConnection con;
        private SqlCommand cmd;
        string name;
        public AccessToDataBase(string name)
        {
            this.name = name;
        }

        public SqlConnection GetConnection()
        {
            con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CaisseThe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            return con;
        }
        public void procInsert(int val1,string val2)
        {
               con.Open();
               cmd = new SqlCommand("insert into Serveurs values('" + val1 + "','" + val2 + "')", con);
               cmd.ExecuteNonQuery();
               MessageBox.Show("data saved");
               con.Close();
        }
        public void procInsertR(int coderecette, string datejour,int reccetparjour,int codeserveur)
        {
            con.Open();
            cmd = new SqlCommand("insert into Recettes values("+ coderecette + ",'" + datejour + "'," + reccetparjour + ","+ codeserveur +")", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data saved");
            con.Close();
        }
        public void procInsertC(int coderecette, string datejour, int reccetparjour, int codeserveur)
        {
            con.Open();
            cmd = new SqlCommand("insert into Recettes values(" + coderecette + ",'" + datejour + "'," + reccetparjour + "," + codeserveur + ")", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data saved");
            con.Close();
        }
        public void procInsertB(int codeboisson, string designation, string prix, int sqtestock)
        {
            con.Open();
            cmd = new SqlCommand("insert into Boissons values(" + codeboisson+ ",'" + designation + "',"+ prix + ","+ sqtestock + ")", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data saved");
            con.Close();
        }
        public void procInsertC(int NumCommand, string dateCom, string heureCom, int codeServeur)
        {
            con.Open();
            cmd = new SqlCommand("insert into Commandes values(" + NumCommand + ",'" + dateCom + "','" + heureCom + "'," + codeServeur + ")", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data saved");
            con.Close();
        }
        public void supp(int val)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM Serveurs WHERE code_serveur=" + val, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data deleted");
            con.Close();
        }
        public void suppB(int val)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM Boissons WHERE code_boisson=" + val, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data deleted");
            con.Close();
        }
        public void suppR(int val)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM Recettes WHERE code_recette=" + val, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data deleted");
            con.Close();
        }
        public void suppC(int val)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM Commandes WHERE numCom=" + val, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data deleted");
            con.Close();
        }
    }
}
