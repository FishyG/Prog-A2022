using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace TestLabo1
{
    internal class Joueur
    {
        public string m_prenom;
        public string m_nom;
        private int m_vie;

        public Joueur(string prenom, string nom)
        {
            m_prenom = prenom;
            m_nom = nom;
            calculVie();
        }

        public void calculVie()
        {
            m_vie = ((m_prenom.Length + m_nom.Length) % 5) +1;
        }

        public int getVie()
        {
            return m_vie;
        }

        public void perdVie()
        {
            if (m_vie > 0)
            {
                m_vie--;
            }
        }
    }
}
