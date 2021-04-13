using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vb2018_0413
{
    class Program
    {
        static void Main(string[] args)
        {
            //2

            string[] sorok = File.ReadAllLines("vb2018.txt");
            List<Stadion> stadionok = new List<Stadion>();
            foreach  (string sor in sorok.Skip(1))
            {
                stadionok.Add(new Stadion(sor));
            }

            //3

            int hossz = stadionok.Count;
            Console.WriteLine($"3. feladat: Stadionok száma: {hossz}");

            //4

            int minIndex = 0;
            for (int i = 1; i < hossz; i++)
            {
                if(stadionok[i].Ferohely < stadionok[minIndex].Ferohely)
                { minIndex = i; }
            }
            Console.WriteLine($"4. feladat: A legkevesebb férőhely::");
            Console.WriteLine($"\tVáros: {stadionok[minIndex].Varos}");
            Console.WriteLine($"\tStadion neve: {stadionok[minIndex].StadionNev}");
            Console.WriteLine($"\tFérőhely: {stadionok[minIndex].Ferohely}");


            Console.ReadLine();
        }
    }
}
