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
using System.Xml.Linq;
using System.ComponentModel.Design;

namespace RRRPGLib
{
    public class listener
    {
        // function to set the text of a label
        public static void setText(Label label, string text)
        {
            label.Invoke(new MethodInvoker(delegate
            {
                label.Text = text;
            }));
        }
        // threads
        Thread hostThread;
        Thread lobbyThread;

        // init function
        public listener(ref MultiPlayer Network, ref PictureBox Opponent, ref PictureBox Opponent2, ref Label OpponentText, ref Label Opponent2Text)
        {
            /*
            List<Object> variables = new List<Object> {
                Network,
                Opponent,
                Opponent2,
                OpponentText,
                Opponent2Text,
            };
            // make and start the thread
            hostThread = new Thread(new ParameterizedThreadStart(listen));
            hostThread.Start(variables);*/
        }
        // function to start the loby thread
        /*
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
        lobbyThread = new Thread(new ParameterizedThreadStart(lobbyListener));
        lobbyThread.Start(variables);
    }*/

        // function for the listenerthred
        /*
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
                for (int x = 0; x < 5 && Network.ips.Count < 2; x++)
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
                        // check they sent a name
                        if (message.Length <= 0 || message[1] == "")
                        {
                            message[1] = "player " + (ip.Length + 1).ToString();
                        }

                        // check that you recieved the correct confirmation message
                        if (message[0] == "join")
                        {
                            // save the ip address to the list
                            Network.ips[Network.ips.Count - 1] = ip;
                            // set their name
                            if (Network.ips.Count == 1)
                            {
                                // set and save the name
                                setText(OpponentText, message[1]);
                                Network.opponentName = message[1];
                                // send your name
                                Network.sendMessage(Network.name, ip);
                            }
                            else if (Network.ips.Count == 2)
                            {
                                // set and save the name
                                setText(Opponent2Text, message[1]);
                                Network.opponentName2 = message[1];

                                // send your name and the opponent name
                                Network.sendMessage(Network.name, ip);
                                Network.sendMessage(Network.opponentName, ip);
                                // send the new opponent name to the old opponent
                                Network.sendMessage(message[1], Network.ips[0]);
                            }
                        }
                        // send a response
                        Network.sendMessage("hola", ip);
                    }
                    Thread.Sleep(100);
                }
            }
        }
        */
        // function to handel the lobby
        /*
        public static void lobbyListener(object objects)
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
        }*/
    }
    public class MultiPlayer
    {
        private String[] rawUserData = new String[3];

        public WeaponType Opponent;
        public WeaponType Opponent2;
        public string opponentName;
        public string opponentName2;

        public bool waiting = true;
        public List<String> ips = new List<string>();
        public int[] ids = new int[2];
        public int test = 0;

        // store the name of the user
        public string name = "host";
        public string hostIp = "none";
        public int ip = 0;
        public int OpponentId = -1;
        public int OpponentId2 = -1;

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
            Network.networkThread = new listener(ref Network, ref Opponent, ref Opponent2, ref OpponentText, ref Opponent2Text);
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

        // function to send a string to an ip
        public void sendMessage(string message)
        {
            // convert the message intop bytes
            byte[] mess = Encoding.ASCII.GetBytes(message);
            // send the message
            udpClient.Send(Encoding.ASCII.GetBytes(message), message.Length, hostIp, 25565);
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
            sendMessage("join", ip);
        }

        // function to wait to start
        public void waitForStart()
        {
            while (this.waiting)
            {
                Thread.Sleep(100);
            }
        }

        // function to broadcast a message
        public void broadCast(string message)
        {
            // loop through the ip addresses
            foreach (string ip in ips)
            {
                sendMessage(message, ip);
            }
        }
        // function to check for labels
        public void checkForUsers(ref Label OpponentText, ref Label Opponent2Text)
        {
            // check if you have recieved data
            if (udpClient.Available > 0)
            {
                // get the data and check it 
                byte[] data = udpClient.Receive(ref endPoint);
                string sData = (System.Text.Encoding.ASCII.GetString(data));

                // get the ip
                string ip = endPoint.Address.ToString();

                // they are joining
                if(sData == "join")
                { 
                    // save the ip address to the list
                    ips.Add(ip);
                    // return their id
                    sendMessage(ips.Count.ToString(), ip);
                }else
                {
                    // split up the message
                    string[] message = sData.Split((char)127);
                    // save the data to the id
                    if (ips.IndexOf(ip) == 0)
                    {
                        Opponent = (WeaponType)(int.Parse(message[0]));
                        opponentName = message[2];
                        sendMessage("0" + (char)127 + sData, ip);
                        rawUserData[0] = sData;
                    }
                    else
                    {
                        Opponent2 = (WeaponType)(int.Parse(message[0]));
                        opponentName2 = message[2];
                        sendMessage("1" + (char)127 + sData, ip);
                        rawUserData[1] = sData;
                    }
                }
                
                // send a response
                sendMessage("hola", ip);
            }
        }
        // function to check for data
        public void checkForData(ref Label Name1, ref Label name2, ref Character op1, ref Character op2)//, ref PictureBox pic1, ref PictureBox pic2)//ref Label message1, ref Label message2)
        {
            // check if you have recieved data
            if (udpClient.Available > 0)
            {
                // get the data and check it 
                byte[] data = udpClient.Receive(ref endPoint);
                string sData = (System.Text.Encoding.ASCII.GetString(data));

                // get ip
                string ip = endPoint.Address.ToString();

                // split up the message
                string[] message = sData.Split((char)127);

                // give the user a number and save the data
                if (message[0] == "0")
                {
                    Opponent = (WeaponType)(int.Parse(message[1]));
                    opponentName = message[2];
                    sendMessage(sData + (char)127 + "0", ip);
                    OpponentId = int.Parse(message[0]);
                } else if (message[0] == "2" || message[0] == "3")
                {
                    Opponent2 = (WeaponType)(int.Parse(message[1]));
                    opponentName2 = message[2];
                    sendMessage(sData + (char)127 + "1", ip);
                    OpponentId2 = int.Parse(message[0]);
                }
            }
        }
        public void sendHostData(WeaponType character)
        {

        }
    }
}
