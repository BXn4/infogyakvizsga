using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszthelySprint
{
    class Program
    {

        static void Main(string[] args)
        {
            int befejeztek = 0;
            int elit_junior = 0;
            double eletkorok = 0;
            double atlageletkor = 0;
            bool vanilyenkategoria = false;
            string rajtszamok = "";
            int legjobbido = int.MinValue;
            string noilegjobbnev = "";
            List<adatok> lista = new List<adatok>();
            foreach (var sor in File.ReadAllLines("Eredmenyek.txt"))
            {
                adatok adat = new adatok(sor);
                lista.Add(adat);
                befejeztek++;
                if (adat.kategoria == "elit junior")
                {
                    elit_junior++;
                }
                eletkorok += 2014 - adat.szuletes;
                atlageletkor = eletkorok / lista.Count;
                atlageletkor = Math.Round(atlageletkor, 1);
                if (adat.nem == 'n')
                {
                    noilegjobbnev = adat.nev;


                }
            }
            Console.WriteLine($"2. feladat: A versenyt {befejeztek} versenyző fejezte be.");
            Console.WriteLine($"3. feladat: Versenyzők száma az 'elit junior' kategóriában {elit_junior} fő");
            Console.WriteLine($"4. feladat: Átlagéletkor: {atlageletkor} év");
            Console.Write("5. feladat: Kérek egy kategóriát: ");
            string kategoria = Console.ReadLine();
            foreach (var sor in lista)
            {
                if (kategoria == sor.kategoria)
                {
                    rajtszamok += sor.rajtszam + " ";
                    vanilyenkategoria = true;
                }
            }
          
            if (vanilyenkategoria == true)
            {
                Console.WriteLine($"\t Rajtszám(ok): {rajtszamok}");
            }
            else
            {
                Console.WriteLine("\t Rajtszám(ok): Nincs ilyen kategória!");
            }
          
            Console.WriteLine($"6. Feladat: A legjobb időt {noilegjobbnev} érte el");
                Console.ReadKey();
            }
        }
    }

