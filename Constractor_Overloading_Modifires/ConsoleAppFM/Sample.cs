using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    enum Days
    {
        Saturday,
        Sunday,
        Monday
    }

    class Sample
    {
        //enum
        public int x = 8;
        public const int y = 100;
        public readonly int z;

        public Sample()
        {
            this.z = 13;
        }
        
        public Sample(int tr)
        {
            this.z = 23;
            this.z = tr;
        }

        public void M1()
        {
            //y = 23;
            int d = y;
            //z = 98;
        }
    }
}
