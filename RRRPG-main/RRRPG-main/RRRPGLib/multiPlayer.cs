﻿using System;
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
using System.Xml.Linq;

namespace RRRPGLib
{
    public class listener
    {
        // threads
        Thread hostThread;
        Thread lobyThread;

        // init function
        public listener(ref MultiPlayer Network, ref PictureBox Opponent, ref PictureBox Opponent2, ref Label OpponentText, ref Label Opponent2Text)
        {
            List<Object> variables = new List<Object> {
                Network,
                Opponent,
                Opponent2,
                OpponentText,
                Opponent2Text,
            };
            // make and start the thread
            hostThread = new Thread(new ParameterizedThreadStart(listen));
            hostThread.Start(variables);
        }
        // function to start the loby thread
        public void startLobby(ref MultiPlayer Network, ref PictureBox Opponent, ref PictureBox Opponent2, ref Label OpponentText, ref Label Opponent2Text)
        {
            OpponentText.Text = "test";
            List<Object> variables = new List<Object> { 
                Network,
                Opponent,
                Opponent2,
                OpponentText,
                Opponent2Text,
            };

            // make and start the thread
            lobyThread = new Thread(new ParameterizedThreadStart(lobyListener));
            lobyThread.Start(variables);
        }

        // function for the listenerthred
        public static void listen(object objects)
        {
            // cast  objects
            var Objects = (List<Object>)objects;
            var Network = (MultiPlayer)Objects[0];
            var Opponent = (PictureBox)Objects[1];
            var Opponent2 = (PictureBox)Objects[2];
            var OpponentText = (Label)Objects[3];
            var Opponent2Text = (Label)Objects[4];

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

                        // split up the message
                        string[] message = sData.Split((char)127);

                        // check that you recieved the correct confirmation message
                        if (message[0] == "join")
                        {
                            // save the ip address to the list
                            Network.ips[Network.ips.Length - 1] = ip;
                        }
                        // set their name
                        if(Network.ips.Length == 0)
                        {
                            OpponentText.Text = message[1];
                        }else if(Network.ips.Length == 1)
                        {
                            Opponent2Text.Text = message[1];
                        }
                        //else if(sData.Split() == "")
                        // send a response
                        Network.sendMessage("hola", ip);
                    }
                    Thread.Sleep(100);
                }
            }
        }
        // function to handel the lobby
        public static void lobyListener(object objects)
        {
            // cast  objects
            var Objects = (List<Object>)objects;
            var Network = (MultiPlayer)Objects[0];
            var Opponent = (PictureBox)Objects[1];
            var Opponent2 = (PictureBox)Objects[2];
            var OpponentText = (Label)Objects[3];
            var Opponent2Text = (Label)Objects[4];

            // check if you are host
            if (Network.isHost)
            {
                // listen for the other users selecting their characters
            }
            else
            {
                // listen for the host sending users

            }
        }
    }
    public class MultiPlayer
    {
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
        public listener networkThread;

        // hold weather or not this is the host
        public bool isHost = false;

        // init function
        public static void hostListener(ref MultiPlayer Network, ref PictureBox Opponent, ref PictureBox Opponent2, ref Label OpponentText, ref Label Opponent2Text)
        {
            // make the thread
            Network.networkThread = new listener(ref Network, ref  Opponent, ref  Opponent2, ref  OpponentText, ref  Opponent2Text);
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
        public void join(string ip, string name)
        {
            hostIp = ip;
            this.name = name;
            sendMessage("join" + (char)127 + name, ip);
        }

        // function to set the labels and picture boxes

    }
}
