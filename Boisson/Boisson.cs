using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAISE
{
    class Boisson
    {
        int code_boisson;
        string desgnation;
        string prix;
        int quantite;

        public Boisson()
        {
            code_boisson = 000;
            desgnation = "???";
            prix = "0";
            quantite = 0;
        }

        public int Code_boisson { get => code_boisson; set => code_boisson = value; }
        public string Desgnation { get => desgnation; set => desgnation = value; }
        public string Prix { get => prix; set => prix = value; }
        public int Quantite { get => quantite; set => quantite = value; }
    }
}
