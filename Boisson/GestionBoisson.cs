using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CAISE.Main_Classes;

namespace CAISE
{
    class GestionBoisson : IGestionBoisson
    {
        private AccessToDataBase db;

        public GestionBoisson()
        {
                db = new AccessToDataBase("Caisse");
                db.GetConnection();
        }
        

        public void ajouter(Boisson boisson)
        {
            db.procInsertB(boisson.Code_boisson,boisson.Desgnation,boisson.Prix,boisson.Quantite);
        }

        public void supp(int code)
        {
            db.suppB(code);
        }
    }
}
