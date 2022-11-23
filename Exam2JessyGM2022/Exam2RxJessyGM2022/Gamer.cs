using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2RxSol2021
{
    internal class Gamer
    {
        public string m_gamerTag;
        public int m_equipe;
        public int m_force;

        public Gamer(string gamerTag, int equipe, int force)
        {
            m_gamerTag = gamerTag;
            m_equipe = equipe;
            m_force = force;
        }
    }
}
