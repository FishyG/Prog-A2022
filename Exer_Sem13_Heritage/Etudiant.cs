using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exer_Sem13_Heritage
{
    internal class Etudiant
    {
        public string nom;
        public int noDa;

        public Etudiant(string n, int sn)
        {
            nom = n;
            noDa = (DateTime.Now.Year * 1000) + sn;
        }

        public int CalculCoteR()
        {
            int total = 0;

            foreach (char lettre in nom)
            {
                total += lettre;
            }
            return total % 50;
        }
        public override string ToString()
        {
            return nom + " DA = " + noDa + " CoteR = " + CalculCoteR();
        }
    }
}
