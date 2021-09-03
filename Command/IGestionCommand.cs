using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAISE
{
    interface IGestionCommand
    {
        void ajouter(Command command);
        void supp(int numcommand);
    }
}
