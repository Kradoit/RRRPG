using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace RRRPGLib
{
    class listener
    {
        Thread thread;
        // init function
        public listener(ref MultiPlayer Network)
        {
            // make and start the thread
            Thread thread = new Thread(new ParameterizedThreadStart(listen));
            thread.Start(Network);
        }
        // function for the listenerthred
        public static void listen(object Network)
        {
            // check if you are host
            
        }
        // function to start the thread
    }
    public class MultiPlayer
    {
        // store the name of the user
        public string name = "host";

        // open a udp socket 
        UdpClient udpClient = new UdpClient(25565);
        // make an open endpoint
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 25565);

        // thead for handeling the network
        listener networkThread;

        // hold weather or not this is the host
        public bool isHost = false;

        // init function
        public MultiPlayer()
        {
            // make the thread
            //networkThread = new listener(this);

        }
        // function to host a game
        public void hostGame()
        {
            // make a thread to listen for new players
            isHost = true;
        }

        // function to send a string to an ip
        private void sendMessage(string message, string ip)
        {
            // convert the message intop bytes
            byte[] mess = Encoding.ASCII.GetBytes(message);
            // send the message
            udpClient.Send(Encoding.ASCII.GetBytes(message), message.Length, ip, 25565);

        }

        // function called to join
        // function called to ping for servers
        public string[] scan()
        {
            // ping all local on 25565 (ping 255.255.255.255)
            this.sendMessage("hello", "255.255.255.255");
            // make a list of strings
            String[] ips = new string[1];

            // loop for a few seconds waiting for a response
            for (int x = 0; x < 5 && ips.Length < 2; x++)
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
                        ips[ips.Length - 1] = this.endPoint.Address.ToString();
                    }
                }
            }
            return ips;
        }
    }
}
