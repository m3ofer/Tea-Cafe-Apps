using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAISE
{
    class Command
    {
        int numCommand;
        string date;
        string time;
        int codeserveur;
        public Command()
        {
            numCommand = 000;
            date = "???";
            time = "???";
            Codeserveur = 0;
        }

        public int NumCommand { get => numCommand; set => numCommand = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public int Codeserveur { get => codeserveur; set => codeserveur = value; }
    }
}
