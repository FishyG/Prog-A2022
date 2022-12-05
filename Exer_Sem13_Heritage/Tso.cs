using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer_Sem13_Heritage
{
    internal class Tso : Etudiant
    {
        public Tso(string s, int numero) : base(s, numero)
        {

        }
        public override string ToString()
        {
            return base.ToString() + "Balls";
        }
    }
}
