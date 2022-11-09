using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientUDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool state = false;

        private void btnSendIt_Click(object sender, EventArgs e)
        {

            UdpClient udp = new UdpClient();
            int toPort;  //port de destination
            IPAddress toIP; //ip de destination
            byte[] msg; //pour l'envoie du message
            IPEndPoint machineDistante;  //sera composé de l'IP et du port

            if (tbMsg.Text.Length != 0) // Champ pas vide ?
            {
                try
                {
                    toIP = IPAddress.Parse(tbIp.Text); //Notez l'utilisation de la méthode Parse vs Convert
                    toPort = int.Parse(tbPort.Text);  //port de destination
                    machineDistante = new IPEndPoint(toIP, toPort);
                    //ou pour un broadcast 
                    //machineDistante = new IPEndPoint(IPAddress.Broadcast, toPort);

                    msg = Encoding.Default.GetBytes(tbMsg.Text);
                    udp.Send(msg, msg.Length, machineDistante);
                }
                catch
                {
                    MessageBox.Show("Erreur d'identification de la station");
                }
            }
        }
    }
}
