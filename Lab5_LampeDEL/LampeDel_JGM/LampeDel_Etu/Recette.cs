using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LampeDel_Etu
{
    class Recette
    {
        /********* constantes ***********/
        public const int NB_DEL = 11;
        //public const int NB_DEMI_HRE = 48;

        public List<int> del { get; set; } //listes d'intensités des DEL
        public bool pointEnr { get; set; } //on veut savoir si cette recette a été enregistrée pour l'usager

        /// <summary>
        /// Constructeur. Construit la liste des DEL. Met à 0 l'intensité de chaque DEL.
        /// Met à false pointEnr 
        /// </summary>
        /// <param name="nb"> nombre de del pour cette recette</param>
        public Recette(int nb)
        {
            pointEnr = false;
            del = new List<int>();  // On instancie 48 objets recettes. 

            for (int i = 0; i < nb; i++)
            {
                del.Add(0); // Ajout d'une DEL avec l'intensité 0
            }
        }
    }
}
