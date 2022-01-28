using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace titanic
{
    class Program
    {
        static void Main(string[] args)
        {
            int kategoriak = 0;
            int szemelyek = 0;
            bool van = false;
            int gyerekek_masodosztaly = 0;
            int nok_elsoosztaly = 0;
            int nok_hajon_dolgozok = 0;
            int nok_masodosztaly = 0;
            int gyerekek_elsoosztaly = 0;
            int nok_harmadosztaly = 0;
            int gyerekek_harmadosztaly = 0;
            int ferfiak_elsoosztaly = 0;
            int ferfiak_legenyseg = 0;
            int ferfiak_harmadosztaly = 0;
            int ferfiak_masodosztaly = 0;
            int min = int.MinValue;
            string legtobbtulelo = "";
            List<adatok> lista = new List<adatok>();
            foreach (var sor in File.ReadLines("titanic.txt"))
            {
                adatok adat = new adatok(sor);
                lista.Add(adat);
                kategoriak++;
                szemelyek += adat.tulelokszama + adat.elntuntek;
                
            }
            Console.WriteLine($"2. feladat: {kategoriak}");
            Console.WriteLine($"3. feladat: {szemelyek} fő");
            Console.Write("4. feladat: Kulcsszó: ");
            string kulcsszo = Console.ReadLine();
            foreach (var sor in lista)
            {
                if(sor.kategoria.Contains(kulcsszo))
                {
                    van = true;
                  
                }
            }
            if(van == true)
            {
                Console.WriteLine("\t Van találat!");
            }
            else
            {
                Console.WriteLine("\t Nincs találat!");
            }
            Console.WriteLine("5. feladat: ");
            foreach (var sor in lista)
            {
                if(sor.kategoria.Contains(kulcsszo))
                {
                    Console.WriteLine($"\t {sor.kategoria} {sor.elntuntek += sor.tulelokszama} fő");
                }
                if(sor.tulelokszama > min)
                {
                    min = sor.tulelokszama;
                    legtobbtulelo = sor.kategoria;
                }
            }
            #region 6.feladat
            Console.WriteLine("6. feladat: ");
       foreach (var sor in lista)
            {
                if (sor.kategoria == "gyerekek-masodosztaly")
                {
                    gyerekek_masodosztaly += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / gyerekek_masodosztaly));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
                if (sor.kategoria == "nok - elsoosztaly")
                {
                    nok_elsoosztaly += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / nok_elsoosztaly));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
                if (sor.kategoria == "nok-hajon dolgozok")
                {
                    nok_hajon_dolgozok += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / nok_hajon_dolgozok));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
                if (sor.kategoria == "nok-masodosztaly")
                {
                    nok_masodosztaly += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / nok_masodosztaly));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
                if (sor.kategoria == "gyerekek-elsoosztaly")
                {
                    gyerekek_elsoosztaly += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / gyerekek_elsoosztaly));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
                if (sor.kategoria == "nok-harmadosztaly")
                {
                    nok_harmadosztaly += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / nok_harmadosztaly));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
                if (sor.kategoria == "gyerekek-harmadosztaly")
                {
                    gyerekek_harmadosztaly += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / gyerekek_harmadosztaly));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
                if (sor.kategoria == "ferfiak-elsoosztaly")
                {
                    ferfiak_elsoosztaly += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / ferfiak_elsoosztaly));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
                if (sor.kategoria == "ferfiak-legenyseg")
                {
                    ferfiak_legenyseg += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / ferfiak_legenyseg));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
                if (sor.kategoria == "ferfiak-harmadosztaly")
                {
                    ferfiak_harmadosztaly += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / ferfiak_harmadosztaly));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
                if (sor.kategoria == "ferfiak-masodosztaly")
                {
                    ferfiak_masodosztaly += sor.tulelokszama + sor.elntuntek;
                    int szazalek = (int)(0.5f + ((100f * sor.elntuntek) / ferfiak_masodosztaly));
                    if (szazalek > 60)
                    {
                        Console.WriteLine($"\t {sor.kategoria}");
                    }
                }
            }
            #endregion
            Console.WriteLine($"7. feladat: {legtobbtulelo}");
            Console.ReadKey();
        }
    }
}
