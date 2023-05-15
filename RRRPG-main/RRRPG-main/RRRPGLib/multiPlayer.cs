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
using System.Reflection.Metadata.Ecma335;

namespace RRRPGLib
{ 
    public class MultiPlayer
    {
        public String[] rawUserData = new String[3];

        // users names
        public string opponentName;
        public string opponentName2;
        public string name = "host";

        // users ips and ids
        public List<String> ips = new List<string>();
        public int[] ids = new int[2];
        public int id = 0;
        public int OpponentId = -1;
        public int OpponentId2 = -1;

        // shost ip
        public string hostIp = "none";

        // open a udp socket 
        public UdpClient udpClient = new UdpClient(25565);
        // make an open endpoint
        public IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 25565);

        // hold weather or not this is the host
        public bool isHost = false;

        // function to host a game
        public void hostGame()
        {
            // set is host to true
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

        // function to send a message to the host
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
            for (int x = 0; x < 5; x++)
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
                Thread.Sleep(100);
            }
            return ips;
        }
        // function to join the server
        public void join(string ip)
        {
            hostIp = ip;
            sendMessage("join", ip);

            // get your id
            for (int x = 0; x < 10; x++)
            {
                // check if you have recieved data
                if (udpClient.Available > 0)
                {
                    byte[] data = udpClient.Receive(ref endPoint);
                    string sData = (System.Text.Encoding.ASCII.GetString(data));

                    if("hola" != sData && sData.Length == 1)
                        id = int.Parse(sData);
                }
                Thread.Sleep(20);
            }

        }
        // function to broadcast a message to all ips in game
        public void broadCast(string message)
        {
            // loop through the ip addresses
            foreach (string ip in ips)
            {
                sendMessage(message, ip);
            }
        }
        private string lastMessage = "";
        private string lastIp = "";
        // function to check for users in lobby
        public void checkForUsers(ref Label OpponentText, ref Label Opponent2Text, ref Character Opponent, ref Character Opponent2)
        {
            // check if you have recieved data
            if (udpClient.Available > 0)
            {
                // get the data and check it 
                byte[] data = udpClient.Receive(ref endPoint);
                string sData = (System.Text.Encoding.ASCII.GetString(data));
                if (!(sData.Equals(lastMessage) && lastIp == this.endPoint.Address.ToString()))
                {
                    // get the ip
                    string ip = endPoint.Address.ToString();

                    // they are joining
                    if (sData == "join")
                    {
                        // save the ip address to the list
                        ips.Add(ip);

                        // return their id
                        sendMessage(((int)ips.Count).ToString(), ip);

                        Thread.Sleep(1000);
                        // send the user all of the data
                        foreach(var x in rawUserData)
                        {
                            if(x!= null)
                                sendMessage(x, ip);
                        }

                     // they are scanning for a server
                    }
                    else if (sData == "hello")
                    {
                        // send a response
                        sendMessage("hola", ip);
                        // they are sending their user data and requesting an id
                    }
                    else // they are ending character information
                    {
                        // split up the message
                        string[] message = sData.Split((char)127);
                        var test = message[0];
                        // save the data to the id
                        if (message[0] == "1")
                        {
                            Opponent = Character.MakeOpponent(convertType.convertToWeapon(int.Parse(message[1])));
                            opponentName = message[2];
                            if(ips.Count>1)
                                sendMessage("1" + (char)127 + sData, ips[1]);
                                rawUserData[1] = sData;
                        }
                        else if (message[0] == "2")
                        {
                            var test22 = message[0];
                            var test2 = message[1];
                            Opponent2 = Character.MakeOpponent(convertType.convertToWeapon(int.Parse(message[1])));
                            opponentName2 = message[2];
                            sendMessage("2" + (char)127 + sData, ips[0]);
                            rawUserData[2] = sData;
                        }
                    }
                    lastMessage = sData;
                    lastIp = this.endPoint.Address.ToString();
                }
            }
        }
        // function to check for data
        public int checkForData(ref Label Name1, ref Label name2, ref Character op1, ref Character op2)//, ref PictureBox pic1, ref PictureBox pic2)//ref Label message1, ref Label message2)
        {
            // check if you have recieved data
            if (udpClient.Available > 0)
            {
                // get the data and check it 
                byte[] data = udpClient.Receive(ref endPoint);
                string sData = (System.Text.Encoding.ASCII.GetString(data));

                // check for start
                if(sData == "GOGOGO")
                {
                    return 1;
                }
                // get ip
                string ip = endPoint.Address.ToString();

                // split up the message
                string[] message = sData.Split((char)127);
                var test = message[0];
                // check the id and save the data
                if (message[0] == "0")
                {
                    op1 = Character.MakeOpponent(convertType.convertToWeapon(int.Parse(message[1])));
                    opponentName = message[2];
                    OpponentId = int.Parse(message[0]);
                } else if (message[0] == "2" || message[0] == "3")
                {
                    op2 = Character.MakeOpponent(convertType.convertToWeapon(int.Parse(message[1])));
                    opponentName2 = message[2];
                    OpponentId2 = int.Parse(message[0]);
                }
            }
            return 0;
        }
        // function to send the user data to the server
        public void sendUserData(WeaponType character)
        {
            if (name == "")
                name = this.id.ToString();
            var message = this.id.ToString() + (char)127 + convertType.convertToInt(character) + (char)127 + name;
            
            // save the raw user data
            if(isHost)
                rawUserData[0] = message;
            
            if (isHost)
                broadCast(message);
            else
                sendMessage(message);
        }
        public string getCurrentCommand()
        { 
            // check if you have recieved data
            if (udpClient.Available > 0)
            {
                // get the data and check it 
                byte[] data = udpClient.Receive(ref endPoint);
                string sData = (System.Text.Encoding.ASCII.GetString(data));
                // check if more than one message was sent
                return sData;
            }
            return null;
        }

        // function to send a command to a user
        public void sendCommand(int id, string Command)
        {
            // send a command to the user
            broadCast(id.ToString() + (char)127 + Command);
        }

        // function to select a character by id for command recieving
        public ref Character SelectChatacter(int id, ref Character player, ref Character opponent, ref Character opponent2)
        {
            // return the correct refrence
            if(id == this.id)
            {
                return ref player; 
            }else if(id == OpponentId)
            {
                return ref opponent;
            }else if(id == OpponentId2)
            {
                return ref opponent2;
            }
            return ref player;
        }

        // function check if a user has pulled the trigger
        public bool pulledTrigger()
        {
            // check if you have recieved data
            if (udpClient.Available > 0)
            {
                // get the data and check it 
                byte[] data = udpClient.Receive(ref endPoint);
                string sData = (System.Text.Encoding.ASCII.GetString(data));
                if (sData == "go")
                    return true;
            }
            return false;
        }
    }
}
