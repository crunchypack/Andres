using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresAnsikte
{
    class Killer
    {
        public string name;
        public int years;
        public string jail;
        
        public Killer()
        {

        }
        public Killer(string name, int years, string jail)
        {
            this.name = name;
            this.years = years;
            this.jail = jail;
        }
        public int YearsLeft()
        {
            int y = 2019;
            int r = y + this.years;
            return r;
        }

    }
}
