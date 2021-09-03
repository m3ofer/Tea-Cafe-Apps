using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAISE
{
    interface IGestionBoisson
    {
        void ajouter(Boisson boisson);
        void supp(int code);
    }
}
