using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vb2018_0413
{
    class Stadion
    {
        public string Varos { get;  }
        public string StadionNev { get;  }
        public string AlternativNev { get; }
        public int Ferohely { get; }

        public Stadion(string sor)
        {
            string[] s = sor.Split(';');
            Varos = s[0];
            StadionNev = s[1];
            AlternativNev = s[2];
            Ferohely = int.Parse(s[3]);
        }
    }
}
