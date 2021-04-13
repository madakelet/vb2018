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


        }
    }
}
