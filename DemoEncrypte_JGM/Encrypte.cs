/**
 * @file   Encrypte.cs
 * @author Benoit Beaulieu
 * @date   septembre 2016
 * @brief  Classe qui permet d'encrypter une chaîne de caractères (string). 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoClasseEncrypte
{
    class Encrypte
    {
        // variables membres de notre classe
        private int m_codeEncryption;		
        private string m_chaineTravail;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Encrypte(int code)
        {
            m_codeEncryption = code;		    
        }

        public void fixeEncryptage(int code)
        {
            m_codeEncryption = code;    // Fixer la valeur de l'encryptage
        }

        public void setChaine(string chaine)
        {
            m_chaineTravail = "";
            int nouveauCar;
            foreach(char c in chaine)
            {
                nouveauCar = Convert.ToInt32(c) + m_codeEncryption;
                m_chaineTravail = m_chaineTravail + Convert.ToChar(nouveauCar);
            }
            
        }

        public string getChaine()
        {
            return m_chaineTravail;
        }
    }
}
