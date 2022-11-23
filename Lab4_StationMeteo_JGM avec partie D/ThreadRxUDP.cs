using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_StationMeteo_JGM
{
    internal class ThreadRxUDP
    {
        const int PORT_RX = 2223;  //Port de réception UDP
        const int MAX_TRAME = 512; //Grosseur max du buffer de réception

        private byte[] m_trameRx = new byte[MAX_TRAME];  //buffer de Rx


        private IPAddress ipClient;  //à titre d'info pour savoir qui a émit la trame UDP
        private int portClient; //idem pour le port

        private UdpClient udpClient;

        private Form ptrMain;

        // Pour le delegate
        public delegate void monProtoDelegate(List<byte> test, string ip);
        public monProtoDelegate objDelegate;

        /// <summary>
        /// Constructeur
        /// </summary>
        public ThreadRxUDP(Form ptrFormPrincipale)
        {
            ptrMain = ptrFormPrincipale; //pour l'appel du delegate
            udpClient = new UdpClient(PORT_RX);
        }


        /// <summary>
        /// Méthode principale appelée par le Thread
        /// </summary>
        public void FaitTravail()
        {
            IPEndPoint IpDistant = new IPEndPoint(IPAddress.Any, 0);

            //le thread tourne toujours dans cette boucle en attente d'une trame UDP
            while (true)
            {
                m_trameRx = udpClient.Receive(ref IpDistant); //le mot ref permet de passer l'adresse d'IpDistant pour que la méthode Receive puisse le modifier. Équivalent à &IpAdresse en C)
                ipClient = IpDistant.Address;  //ip du client UDP qui a émit la trame
                portClient = IpDistant.Port;   //port du client UDP qui a émit la trame

                ptrMain.BeginInvoke(objDelegate, Encoding.Default.GetBytes(GetMsgRecu()).ToList(), ipClient.ToString() + ":" + portClient.ToString()); //Appel de la méthode delegateAffiche(string msgRecu via BeginInvoke
            }
        }

        /// <summary>
        /// Construit une string avec l'ip, le port et le message reçu.
        /// </summary>
        /// <returns>L'adr IP, le port et la trame reçue formatés en String </returns>
        public string GetMsgRecu()
        {
            if (ipClient != null)
                return Encoding.Default.GetString(m_trameRx);// Encoding.ASCII.GetString(m_trameRx);
            else
                return "";
        }

        public void ArreteClientUDP()
        {
            udpClient.Close();
        }
    }
}
