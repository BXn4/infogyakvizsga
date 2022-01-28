using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace helsinki1952project
{
    class helsinki1952
    {
        static void Main(string[] args)
        {
            int pontszerzo = 0;
            int arany = 0;
            int ezust = 0;
            int bronz = 0;
            int osszesen = 0;
            int olimpiaipontok = 0;
            int uszas = 0;
            int torna = 0;
            int helyezes = 0;
            string sportag = "";
            string versenyszam = "";
            int sportolokszama = int.MinValue;
            int legnagyobbcsapat = 0;
            List<adatok> lista = new List<adatok>();
            foreach (var sor in File.ReadAllLines("helsinki.txt"))
            {
                adatok adat = new adatok(sor);
                lista.Add(adat);
                pontszerzo++;
                if(adat.helyezes == 1)
                {
                    arany++;
                    olimpiaipontok = olimpiaipontok + 7;
                }
                if(adat.helyezes == 2)
                {
                    ezust++;
                    olimpiaipontok = olimpiaipontok + 5;
                }
                if(adat.helyezes == 3)
                {
                    bronz++;
                    olimpiaipontok = olimpiaipontok + 4;
                }
                if(adat.helyezes == 4)
                {
                    olimpiaipontok = olimpiaipontok + 3;
                }
                if(adat.helyezes == 5)
                {
                    olimpiaipontok = olimpiaipontok + 2;
                }
                if (adat.helyezes == 6)
                {
                olimpiaipontok = olimpiaipontok + 1;
                }
                osszesen = arany + ezust + bronz;
                if(adat.sportagneve == "uszas")
                {
                    uszas++;
                }
                if (adat.sportagneve == "torna")
                {
                    torna++;
                }
                if (adat.sportagneve == "kajakkenu")
                {
                    File.WriteAllText("helsinki.txt", File.ReadAllText("helsinki.txt").Replace("kajakkenu", "kajak-kenu"));

                }
                if(adat.sportolokszama > sportolokszama)
                {
                    sportolokszama = adat.sportolokszama;
                    sportag = adat.sportagneve;
                    helyezes = adat.helyezes;
                    versenyszam = adat.versenyszam;
                }
            }
            Console.WriteLine($"3. feladat: \nPontszerző helyezések száma: {pontszerzo}");
            Console.WriteLine($"4. feladat: \nArany: {arany}\nEzüst: {ezust}\nBronz: {bronz}\nÖsszesen: {osszesen}");
            Console.WriteLine($"5. feladat: \nOlimpiai pontok száma: {olimpiaipontok}");
            Console.WriteLine($"6. feladat:");
            if(uszas == torna)
            {
                Console.WriteLine("Egyenlő volt az érmek száma");
            }
            else if(uszas < torna)
            {
                Console.WriteLine("Torna sportágban szereztek több érmet");
            }
            else if (uszas > torna)
            {
                Console.WriteLine("Úszás sportágban szereztek több érmet");
            }
            Console.WriteLine($"Helyezés: {helyezes}");
            Console.WriteLine($"Sportág: {sportag}");
            Console.WriteLine($"Versenyszám: {versenyszam}");
            Console.WriteLine($"Sportolók száma: {sportolokszama}");
            Console.ReadKey();
        }
    }
}
