/**
 * @file   Lcd4Lignes.cs
 * @author R. Cloutier
 * @date   septembre 2014
 * @brief  Classe qui génère un affichage sur 4 lignes
 *
 * @version 1.0 : Première version utilisée à l'automne 2013
 * @version 1.1:  automne 2014: Ajout des commentaires et passage à visual studio 2013
 * @version 1.2:  automne 2015: Ajout des 2 constantes RANGEE_MAX_ ET COLONNE_MAX. Benoit Beaulieu
 * @version 1.3:  automne 2016 Modifié (colonneSelectionnee_ + '1')  par (colonneSelectionnee_ + '0') dans méthode gestionModesAffichage(). Benoit Beaulieu
 * Environnement: Visual Studio 2013
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_MachineDistributrice_JGM
{
    /// <summary>
    /// Classe qui permet de générer le texte à afficher sur 4 lignes en fonction de différentes informations
    /// </summary>
    class Lcd4Lignes
    {
        
        /// <summary>
        /// Valeurs utilisées pour définir l'état courant de la logique d'affichage
        /// </summary>
        enum etatAffichage 
        {
            Init = 0,
            Defaut,
            AttenteColonne,
            AttenteConfirmation,
            Distribution,
            ManqueCredit,
            QteZero,
            Annulation
        };

        private const int RANGEE_MAX_ = 6;
        private const int COLONNE_MAX_ = 10;

        /// <summary>
        /// Défnition des 4 chaînes de caractères qui sont utilisées pour contenir le contenu à afficher
        /// </summary>
        private String[] lignesAffichage_ = new String[4]; // contenu des 4 lignes à afficher 

        /// <summary>
        /// "Getter et setter" des 4 lignes d'affichage
        /// </summary>
        public String[] lignesAffichage // définition des méthodes get/set sur la variable membre
        {
            get { return lignesAffichage_; }
            set { lignesAffichage_ = value; }
        }

        /* Définition de l'ensemble des variables membres qui seront utilisées pour gérer la logique d'affichage */
        private int      rangeeSelectionnee_  = 0;
        private int      colonneSelectionnee_ = 0;
        private int      prixCourant_         = 0;
        private int      creditCourant_       = 0;
        private int      creditPrecedent_      = 0;
        private int      retourCourant_       = 0;
        private Boolean     distributionActive_  = false;
        private Boolean     annulationActive_    = false;
        private Boolean     manqueCreditActif_   = false;
        private Boolean     quantiteZeroActif_   = false;
        private int      etatCourantAffichage_       = (int)etatAffichage.Init;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Lcd4Lignes()
        {

        }

        /// <summary>
        /// Méthode servant à générer l'affichage en fonction des paramètres déjà reçus.
        /// </summary>
        /// <returns></returns>
        public Boolean genererAffichage()
        {
            return gestionModesAffichage();
        }

        /// <summary>
        /// Méthode utilisée pour recevoir les différents paramètres liés au contrôle de l'affichage.
        /// </summary>
        /// <param name="iIndexRangee">valide entre 0 et 5 -> équivaut aux lettres entre A et F</param>
        /// <param name="iIndexColonne">valide entre 0 et 3</param>
        /// <param name="iCreditCents">valeur en cents</param>
        /// <param name="iRetourCents">valeur en cents</param>
        /// <param name="iPrixCents">valeur en cents</param>
        /// <param name="iDistributionEnCours">true si cet état est actif</param>
        /// <param name="iManqueCreditActif">true si cet état est actif</param>
        /// <param name="iAnnulationEnCours">true si cet état est actif</param>
        /// <param name="iQteZeroEnCours">true si cet état est actif</param>
        /// <returns></returns>
        public Boolean genererAffichage(int iIndexRangee, int iIndexColonne, int iCreditCents, int iRetourCents, int iPrixCents,
                                            Boolean iDistributionEnCours, Boolean iManqueCreditActif, Boolean iAnnulationEnCours, Boolean iQteZeroEnCours)
        {
            rangeeSelectionnee_     = iIndexRangee; // a -> f 
            colonneSelectionnee_ = iIndexColonne;   // 0 -> 3
            creditCourant_ = iCreditCents;
            retourCourant_ = iRetourCents;
            distributionActive_ = iDistributionEnCours;
            manqueCreditActif_ = iManqueCreditActif;
            annulationActive_ = iAnnulationEnCours;
            prixCourant_ = iPrixCents;
            quantiteZeroActif_ = iQteZeroEnCours;
            return gestionModesAffichage();
        }

        /// <summary>
        /// Méthode qui génère l'affichage
        /// </summary>
        /// <returns>true s'il faut faire un "refresh" de l'affichage...</returns>
        private Boolean gestionModesAffichage()
        {
            Boolean demandeRafraichirAffichage = false;
            int  etatCourantAffichage = (int)etatAffichage.Defaut;

            // section de gestion du mode courant
            if (true == distributionActive_) // distribution en cours
            {
                etatCourantAffichage = (int)etatAffichage.Distribution;
            }
            else if (true == annulationActive_)
            {
                etatCourantAffichage = (int)etatAffichage.Annulation;
            }
            else if (true == manqueCreditActif_)
            {
                etatCourantAffichage = (int)etatAffichage.ManqueCredit;
            }
            else if (true == quantiteZeroActif_)
            {
                etatCourantAffichage = (int)etatAffichage.QteZero;
            }
            else if (rangeeSelectionnee_ < RANGEE_MAX_)
            {
                if (colonneSelectionnee_ < COLONNE_MAX_) // attente de credit
                {
                    etatCourantAffichage = (int)etatAffichage.AttenteConfirmation;
                }
                else // attente de colonne
                {
                    etatCourantAffichage = (int)etatAffichage.AttenteColonne;
                }
            
            }
            
            
            // validation s'il faut forcer un rafraîchissement de l'affichage à cause de l'état ou à cause d'un changement de crédit
            if ((etatCourantAffichage != etatCourantAffichage_) ||
                (creditPrecedent_ != creditCourant_))
            {
                etatCourantAffichage_ = etatCourantAffichage;
                demandeRafraichirAffichage = true;

                // appel des fonctions de generation de lignes
                lignesAffichage_[0] = " ";
                lignesAffichage_[1] = " ";
                lignesAffichage_[2] = " ";
                lignesAffichage_[3] = " ";

                double valeurDollars = 0.0f;
                String stringDollars = " ";

                switch (etatCourantAffichage)
                {
                    case (int)etatAffichage.AttenteColonne:
                        lignesAffichage_[0] = "Attente colonne";
                        lignesAffichage_[1] = "Rangée sélectionnée: " + Convert.ToChar(rangeeSelectionnee_   + 'A');
                        break;
                    case (int)etatAffichage.AttenteConfirmation:
                        lignesAffichage_[0] = "Appuyer sur ENTER pour confirmer";
                        lignesAffichage_[1] = "Case sélectionnée: " + Convert.ToChar(rangeeSelectionnee_ + 'A') + Convert.ToChar(colonneSelectionnee_ + '0');
                        valeurDollars = Convert.ToDouble(prixCourant_) / 100.0f;
                        stringDollars = String.Format("{0:0.00}", valeurDollars);
                        lignesAffichage_[2] = "Prix ($): " + stringDollars;
                        break;
                    case (int)etatAffichage.Distribution:
                        lignesAffichage_[0] = "Achat confirmé: " + Convert.ToChar(rangeeSelectionnee_ + 'A') + Convert.ToChar(colonneSelectionnee_ + '0'); 
                        valeurDollars = Convert.ToDouble(retourCourant_)/100.0f;
                        stringDollars = String.Format("{0:0.00}", valeurDollars);
                        lignesAffichage_[1] = "Retour ($): " + stringDollars;
                        break;
                    case (int)etatAffichage.Annulation:
                        lignesAffichage_[0] = "ANNULATION DE LA VENTE"; 
                        valeurDollars = Convert.ToDouble(retourCourant_)/100.0f;
                        stringDollars = String.Format("{0:0.00}", valeurDollars);
                        lignesAffichage_[1] = "Retour ($): " + stringDollars;
                        break;
                    case (int)etatAffichage.ManqueCredit:
                        lignesAffichage_[0] = "MANQUE ($)";
                        valeurDollars = Convert.ToDouble(prixCourant_-creditCourant_) / 100.0f;
                        stringDollars = String.Format("{0:0.00}", valeurDollars);
                        lignesAffichage_[1] = "Montant manquant ($): " + stringDollars;
                        valeurDollars = Convert.ToDouble(prixCourant_) / 100.0f;
                        stringDollars = String.Format("{0:0.00}", valeurDollars);
                        lignesAffichage_[2] = "Prix ($): " + stringDollars;
                        break;
                    case (int)etatAffichage.QteZero:
                        lignesAffichage_[0] = "CASE VIDE "; 
                        //valeurDollars = Convert.ToDouble(retourCourant_)/100.0f;
                        //stringDollars = String.Format("{0:0.00}", valeurDollars);
                        //lignesAffichage_[1] = "Retour ($): " + stringDollars;
                        break;
                    default:
                        lignesAffichage_[0] = "Veuillez entrer votre sélection";
                        break;
                };

                valeurDollars = Convert.ToDouble(creditCourant_) / 100.0f;
                stringDollars = String.Format("{0:0.00}", valeurDollars);
                lignesAffichage_[3] = "Crédit ($): " + stringDollars;
            }
            creditPrecedent_ = creditCourant_;

            return demandeRafraichirAffichage;
        }
    }
}


