using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClasseResistance
{
    internal class Resistance
    {
        public int m_valRes;
        public Resistance(int valRes)
        {
            m_valRes = valRes;
        }
        public int geti(int volts)
        {
            return 1000*volts/m_valRes;
        }
    }
}
