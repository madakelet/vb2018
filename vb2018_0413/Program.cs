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

            //5

            int osszesFHely = 0;
            foreach (Stadion stadion in stadionok)
            {
                osszesFHely += stadion.Ferohely;
            }
            Console.WriteLine($"5. feladat: Átlagos férőhelyszám: {(osszesFHely*1.0)/hossz:F1}");

            //6

            int alterStadionok = 0;
            foreach  (Stadion stadion in stadionok)
            {
                if(stadion.AlternativNev != "n.a.")
                { alterStadionok++; }
            }

            Console.WriteLine($"6. feladat: Két néven is ismert stadionok száma: {alterStadionok}");

            //7

            bool jo = false;
            string bekertNev;
            do
            {
                Console.Write("7. feladat: Kérem a város nevét: ");
                bekertNev = Console.ReadLine();
                jo = bekertNev.Length > 2;
            } while (!jo);


            //8

            int j = 0;
            while(j < hossz && !(stadionok[j].Varos==bekertNev))
            { j++; }
            bool van = j < hossz;
            string van_e = van ? "" : "nem";
            
            Console.WriteLine($"8. feladat: A megadott város {van_e} VB helyszín");

            Console.ReadLine();

        }
    }
}
