using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RRRPGLib
{
    class listener
    {
        // threads
        Thread hostThread;
        Thread lobyThread;

        // init function
        public listener(ref MultiPlayer Network)
        {
            // make and start the thread
            hostThread = new Thread(new ParameterizedThreadStart(listen));
            hostThread.Start(Network);
        }
        // function to start the loby thread
        public void startLobby(ref object network, ref PictureBox Player, ref PictureBox Opponent, ref PictureBox Opponent2)
        {
            // cast the 
            var Network = (MultiPlayer)network;
            // make and start the thread
            Thread thread = new Thread(new ParameterizedThreadStart(listen));
            thread.Start(Network);
        }

        // function for the listenerthred
        public static void listen(object network)
        {
            var Network = (MultiPlayer)network;
            // listen for users
            while (true)
            {
                // loop for a few seconds waiting for a response
                for (int x = 0; x < 5 && Network.ips.Length < 2; x++)
                {
                    // check if you have recieved data
                    if (Network.udpClient.Available > 0)
                    {
                        // get the data and check it 
                        byte[] data = Network.udpClient.Receive(ref Network.endPoint);
                        string sData = (System.Text.Encoding.ASCII.GetString(data));

                        // get the ip
                        string ip = Network.endPoint.Address.ToString();

                        // check that you recieved the correct confirmation message
                        if (sData == "join")
                        {
                            // save the ip address to the list
                            Network.ips[Network.ips.Length - 1] = ip;
                        }
                        // send a response
                        Network.sendMessage("hola", ip);
                    }
                    Thread.Sleep(100);
                }
            }
        }
        // function to handel the lobby
        public static void lobyListener(object network, PictureBox Player, PictureBox Opponent, PictureBox Opponent2)
        {
            // cast network object
            var Network = (MultiPlayer)network;

            // check if you are host
            if (Network.isHost)
            {

            }
            else
            {

            }
        }
    }
    public class MultiPlayer
    {
        PictureBox Player;
        PictureBox Opponent1;
        PictureBox Opponent2;

        Label playerText;
        Label OpponentText;
        Label Opponent2Text;

        public String[] ips = new string[1];
        public int test = 0;
        // store the name of the user
        public string name = "host";
        public string hostIp = "none";

        // open a udp socket 
        public UdpClient udpClient = new UdpClient(25565);
        // make an open endpoint
        public IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 25565);

        // thead for handeling the network
        listener networkThread;

        // hold weather or not this is the host
        public bool isHost = false;

        // init function
        public static void startListening(ref MultiPlayer Network)
        {
            // make the thread
            Network.networkThread = new listener(ref Network);
        }
        // function to host a game
        public void hostGame()
        {
            // make a thread to listen for new players
            isHost = true;
        }

        // function to send a string to an ip
        public void sendMessage(string message, string ip)
        {
            // convert the message intop bytes
            byte[] mess = Encoding.ASCII.GetBytes(message);
            // send the message
            udpClient.Send(Encoding.ASCII.GetBytes(message), message.Length, ip, 25565);
        }

        // function called to join
        // function called to ping for servers
        public List<string> scan()
        {
            // ping all local on 25565 (ping 255.255.255.255)
            this.sendMessage("hello", "255.255.255.255");

            List<string> ips = new List<string>();
            // loop for a few seconds waiting for a response
            for (int x = 0; x < 3; x++)
            {
                // check if you have recieved data
                if (this.udpClient.Available > 0)
                {
                    // get the data and check it 
                    byte[] data = this.udpClient.Receive(ref this.endPoint);
                    string sData = (System.Text.Encoding.ASCII.GetString(data));
                    Console.Write(sData);
                    // check that you recieved the correct confirmation message
                    if (sData == "hola")
                    {
                        // save the ip address to the list
                        ips.Add(this.endPoint.Address.ToString());
                        break;
                    }
                }
                Thread.Sleep(1000);
            }
            return ips;
        }
        // function to join the server
        public void join(string ip)
        {
            hostIp = ip;
            sendMessage("join", ip);
        }

        // function to set the labels and picture boxes

    }
}
