using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace feb17
{
    class auto
    {
        private string marka;
        private string modell;
        private string evjarat;
        private string km;
        private string uzemanyag;
        private string ar;

        public auto(string marka, string modell, string evjarat, string km, string uzemanyag, string ar)
        {
            this.Marka = marka;
            this.Modell = modell;
            this.Evjarat = evjarat;
            this.Km = km;
            this.Uzemanyag = uzemanyag;
            this.Ar = ar;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public string Evjarat { get => evjarat; set => evjarat = value; }
        public string Km { get => km; set => km = value; }
        public string Uzemanyag { get => uzemanyag; set => uzemanyag = value; }
        public string Ar { get => ar; set => ar = value; }

        public override string ToString()
        {
            return String.Format(Marka + ";" + Modell + ";" + Evjarat + ";" + Uzemanyag + ";" + Ar);
        }

        
    }
}
