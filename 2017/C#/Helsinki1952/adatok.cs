using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki1952project
{
    class adatok
    {
        public int helyezes { get; set; }
        public int sportolokszama { get; set; }
        public string sportagneve { get; set; }
        public string versenyszam { get; set; }

        public adatok(string sor)
        {
            string[] tomb = sor.Split(' ');
            helyezes = Convert.ToInt32(tomb[0]);
            sportolokszama = Convert.ToInt32(tomb[1]);
            sportagneve = tomb[2];
            versenyszam = tomb[3];
        }
    }
}
