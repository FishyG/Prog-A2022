using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_MachineDistributrice_JGM
{
    internal class ItemInventaire
    {
        private int m_prix;
        private int m_quantite;

        //Création des propriétés prix et quantite et des méthodes get permettant de lire les variables privées 
        //m_prix et m_quantite.
        //Aucune méthode set, car on protège nos variables privées. L'usager devra utiliser les méthodes
        //modifierInventaire et diminuerInventaire pour modifier les variables
        public int prix
        {
            get
            {
                return m_prix;
            }
        }

        public int quantite
        {
            get
            {
                return m_quantite;
            }
        }


        /// <summary>
        /// Constructeur. Doit utiliser la méthode modifierInventaire pour assigner les prix et quantite
        /// </summary>
        /// <param name="prixItem"> on reçoit le prix de l'item lors de sa création</param>
        /// <param name="qteItem"> on reçoit la quantité de l'item lors de sa création<</param>
        public ItemInventaire(int prixItem, int qteItem)
        {
            modifierInventaire(prixItem,qteItem);
        }



        /// <summary>
        /// Permet de modifier le prix et la quantité d'un item de l'inventaire s'ils sont valides
        /// </summary>
        /// <param name="oPrix">Doit être entre 0.25$ et 3.00$ et un multiple de 5 cents</param>
        /// <param name="oQuantite">Doit être entre 1 et 9 inclusivement</param>
        /// <returns>Vrai si la modification a réussi. Faux si non.</returns>
        public bool modifierInventaire(int oPrix, int oQuantite)
        {
            bool retour = false;

            if (((oPrix >= 25 && oPrix <= 300) && (oPrix % 5 == 0))) // Si plus que 25$, moins que 300$ et un multiple de 5 cents
            {
                if (oQuantite >= 1 && oQuantite <= 9)    // Si la quantité est mauvaise retourne 
                {
                    m_prix = oPrix;
                    m_quantite = oQuantite;
                    retour = true;  // Retourne true si l'opération a fonctionné
                }
            }

            return retour;
        }

        /// <summary>
        /// Moins un sur la qte si > 0
        /// </summary>
        public void diminuerInventaire()
        {
            if(m_quantite > 0)  // Si la quantité est plus que 0
                m_quantite--;   // Diminue la quantité de 1
        }
    }
}
