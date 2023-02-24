using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszogekCLI
{
    public class Haromszog
    {
        public int oldalA { get; private set; }
        public int oldalB { get; private set; }
        public int oldalC { get; private set; }

        public Haromszog(string sor)
        {
            string[] darabok = sor.Split(' ');
            this.oldalA = Convert.ToInt32(darabok[0]);
            this.oldalB = Convert.ToInt32(darabok[1]);
            this.oldalC = Convert.ToInt32(darabok[2]);
        }
    }
}
