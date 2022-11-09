using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeurUDP
{
    public partial class Form1 : Form
    {
        Thread objTh;  //On fera tourner l'objet objThUDP dans un Thread pour la rx de la trame
        ThreadRxUDP objUDP;

        public Form1()
        {
            InitializeComponent();

            //On instencie les obj et lance le Thread
            objUDP = new ThreadRxUDP(this);
            objUDP.objDelegate = delegateAffiche; //on instencie le delegate (En bref, objDelegate est un pointeur de fonction qui pointe sur DelegateAffiche.
            objTh = new Thread(objUDP.FaitTravail);
            objTh.Start();
        }

        //Méthode delegate
        private void delegateAffiche(string msgRecu)
        {
            if (msgRecu != "")  //code pour afficher
                lb_Rx.Items.Add(msgRecu);
        }

        /// <summary>
        /// Comme on n'a pas de delegate, on doit utiliser un bouton pour rafraichir l'affichage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LastReceived_Click(object sender, EventArgs e)
        {
            string msg;
            msg = objUDP.GetMsgRecu();
            if (msg != "")
                lb_Rx.Items.Add(msg);
        }

        /// <summary>
        /// Arrêt du Socket et du Thread avant de quitter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            objUDP.ArreteClientUDP();
            objTh.Abort();
        }
    }
}
