using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoServeurUDP
{

    internal class Personnage
    {
        public string nom { get; set; }
        public string couleur { get; set; }

        private int nbVotes;

        public Personnage(string nomPerso, string couleurPerso)
        {
            nbVotes = 0;
            nom = nomPerso;
            couleur = couleurPerso;
        }

        public void voter()
        {
            if (nbVotes < 20)
                nbVotes++;
        }

        public int getNbVotes()
        {
            return nbVotes;
        }
    }
}
