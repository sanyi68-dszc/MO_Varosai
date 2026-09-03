using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    class Varos
    {
        public Varos(string nev, string jaras, string kisterseg, int nepesseg, double terulet)
        {
            Nev = nev;
            Jaras = jaras;
            Kisterseg = kisterseg;
            Nepesseg = nepesseg;
            Terulet = terulet;
        }

        public string Nev { get; set; }
        public string Jaras { get; set; }
        public string Kisterseg { get; set; }
        public int Nepesseg { get; set; }
        public double Terulet { get; set; }
    }
}
