using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszthelySprint
{
    class adatok
    {
        public string nev { get; set; }
        public double szuletes { get; set; }
        public int rajtszam { get; set; }
        public char nem { get; set; }
        public string kategoria { get; set; }
        public string uszas { get; set; }
        public string elsodepo { get; set; }
        public string kerekparozas { get; set; }
        public string masodikdepo { get; set; }
        public string futas { get; set; }
        public adatok(string sor)
        {
            string[] tomb = sor.Split(';');
            nev = tomb[0];
            szuletes = Convert.ToDouble(tomb[1]);
            rajtszam = Convert.ToInt32(tomb[2]);
            nem = Convert.ToChar(tomb[3]);
            kategoria = tomb[4];
            uszas = tomb[5];
            elsodepo = tomb[6];
            kerekparozas = tomb[7];
            masodikdepo = tomb[8];
            futas = tomb[9];
        }
    }
}
