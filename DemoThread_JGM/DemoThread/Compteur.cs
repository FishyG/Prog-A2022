using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoThread
{
    internal class Compteur
    {
        private Form ptrMain;

        public delegate void monProtoDelegate(int value);
        public monProtoDelegate objDelegate;

        public int m_compteur { get; set; }
        public bool m_pause { get; set; }
        private Form m_formPrincipal;

        public Compteur(int compteur, bool pause, Form formrecu)
        {
            m_compteur = compteur;
            m_pause = pause;
            m_formPrincipal = formrecu;
        }

        public void faitTravail()
        {
            while (true)
            {
                try
                {
                    if (m_pause)
                    {
                        Thread.Sleep(Timeout.Infinite);
                    }
                    else
                    {
                        m_compteur++;
                        Thread.Sleep(500);
                        m_formPrincipal.BeginInvoke(objDelegate, m_compteur);
                    }
                }
                catch(ThreadInterruptedException e)
                {
                    // Au besoin afficher un message pour avertir qu'on a quitter le sleep infini
                }
            }
        }
    }
}
