using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanic
{
    class adatok
    {
        public string kategoria { get; set; }
        public int tulelokszama { get; set; }
        public int elntuntek { get; set; }

        public adatok(string sor)
        {
            string[] tomb = sor.Split(';');
            kategoria = tomb[0];
            tulelokszama = Convert.ToInt32(tomb[1]);
            elntuntek = Convert.ToInt32(tomb[2]);
        }
    }
}
