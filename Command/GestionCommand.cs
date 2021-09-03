using CAISE.Main_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAISE
{
    class GestionCommand : IGestionCommand
    {
        private AccessToDataBase db;
       
        public GestionCommand()
        {
            db = new AccessToDataBase("Caisse");
            db.GetConnection();
        }

        public void ajouter(Command command)
        {
            db.procInsertC(command.NumCommand, command.Date, command.Time,command.Codeserveur);
        }

        public void supp(int numcommand)
        {
            db.suppC(numcommand);
        }
    }
}
