using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    internal class Ember
    {
        public string name { get; set; }
        public int birthyear { get; set; }

        public Ember(string name, int birthyear)
        {
            this.name = name;
            this.birthyear = birthyear;
        }
    }
}
