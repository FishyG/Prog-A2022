using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Semain5___Joueur
{
    internal class Joueur
    {
        public int team;
        public string name;

        public Joueur(string playerName)
        {
            team = playerName.Length % 2;
            name = playerName;
        }   

        public int getForce()
        {
            int force = 0;
            foreach (char c in name)
            {
                force += c;
            }
            return force;
        }
    }
}