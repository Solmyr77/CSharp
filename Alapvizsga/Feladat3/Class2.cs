using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat3
{
    internal class Utas
    {
        public int kedvezmeny;
        public int km;
        public int jegyar;

        public Utas(int akedvezmeny, int akm)
        {
            kedvezmeny = akedvezmeny;
            km = akm;

            jegyar = (km * 50 * (1 - kedvezmeny / 100));
        }

        int km_price()
        {
            return this.jegyar / this.km;
        }
    }
}
