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
    public class MultiPlayer
    {
        // open a udp socket 
        UdpClient udpClient = new UdpClient(25565);
        // make an open endpoint
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 25565);

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
