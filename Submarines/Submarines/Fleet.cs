using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submarines
{

    //LIST WRAPPER CLASS - STATIC ACCESS TO THE SUBFLEET LIST.
    class Fleet
    {
        public static List<Submarine> subFleet = new List<Submarine>();

        public void addSub(Submarine sub)
        {
            subFleet.Add(sub);
        }

    }
}
