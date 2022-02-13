﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Box_v0._1;

//using Newtonsoft.Json;

namespace The_Box_v0._1
{
    class ClientSocket
    {
        static NetworkStream networkStream;
        static TcpClient Socket;
        static int port=5001;
        static BinaryWriter streamWriter;
        static BinaryReader streamReader;
        static TcpClient ny;
        static ClientSocket()
        {
            //ClientSocket.port = port;
            ny = new TcpClient();

            Console.WriteLine("hello1");
            ny.Connect(IPAddress.Parse("127.0.0.1"), ClientSocket.port);

            networkStream = ny.GetStream();

            streamWriter =
     new BinaryWriter(networkStream);
            streamReader =
                 new BinaryReader(networkStream);
        }

        public static void SendRequest(string s)
        {
            streamWriter.Write(s);
        }

        public static Room Responseplay(string id)
        {
            String s = streamReader.ReadString();
            if (s == "play")
            {
                MessageBox.Show("ana 2bl");
                streamWriter.Write(id);
             return   Room.DeepReceive(streamReader);
            }
            return null;


        }
        public static Room ResponseJoin(User Myuser, string id)
        {
            String s = streamReader.ReadString();
            if (s == "join")
            {
                Console.WriteLine("Start Join");

                Console.WriteLine("AnaBreceive");
                User.SendPlayer(Myuser, streamWriter);

                Console.WriteLine("Enter Id of Room");
            //    String Idroom = Console.ReadLine();
                streamWriter.Write(id);

               return  Room.ReceiveRoom(streamReader);
             //   Console.WriteLine("I receive room!");
            }
            return null;
        }
        public static void  ResponseLog(User user)
        {

            String s = streamReader.ReadString();

            if (s == "log")
            {
                MessageBox.Show("ana Da5lt ellog ");
                User.SendPlayer(user, streamWriter);




            }
        }

        public static void ResponseShowplayer(List<User> players)
        {
            String s = streamReader.ReadString();
            if (s == "showplayer")
            {
                MessageBox.Show("ana Da5lt players ");
                //  Console.WriteLine("ana Da5lt join ");

                Console.WriteLine(streamReader.ReadString());
                s = streamReader.ReadString();
                //  MessageBox.Show("ana 3mlt recevie");
                // Room ag = new Room(Myuser, "ahmed", "fsadf");

                while (s != "end")
                {




                    User receivedpayer = User.Receiver(s);

                    players.Add(receivedpayer);
                    Console.WriteLine("I receive room!");
                    s = streamReader.ReadString();


                }

                Console.WriteLine("Yes i Do it ");
            }
        }

        public static void ResponseShowRooms(List<Room> rooms)
        {
            String s = streamReader.ReadString();
            if (s == "showRooms")
            {
                MessageBox.Show("ana Da5lt rooms ");

                Console.WriteLine("ana Da5lt join ");

                Console.WriteLine(streamReader.ReadString());
                s = streamReader.ReadString();
                //  MessageBox.Show("ana 3mlt recevie");
                //Room ag = new Room(Myuser, "ahmed", 5);
                //rooms.Add(ag);
                while (s != "end")
                {


                    Room receivedRoom = Room.ReceiveRoom(s);
                    
                    rooms.Add(receivedRoom);
                    Console.WriteLine("I receive room!");
                    s = streamReader.ReadString();


                }

                Console.WriteLine("Yes i Do it ");
            }


        }

        public static Room ResponseCreate(User player1,string id, int index)
        {
            String s = streamReader.ReadString();

            if (s == "create")
            {
                Console.WriteLine("AnaBreceive");
                User.SendPlayer(player1, streamWriter);

                Console.WriteLine("Enter Id of Room");
                //String Idroom = Console.ReadLine();
                streamWriter.Write(id);
                Console.WriteLine("Enter Size Of room");
                //String size = Console.ReadLine();
                streamWriter.Write(index.ToString());
                Console.WriteLine("I receive room!");

                return Room.ReceiveRoom(streamReader);


               // Myuser.room = room;
            }

            return Room.ReceiveRoom(streamReader);
        }





            public static void CheckRespornse(User Myuser,List<Room> rooms,List<User> players,Room CreatedRoom)
        {





            {

                Console.WriteLine("Enter New Command:");

                String s = streamReader.ReadString();

                if (s == "log")
                {
                    MessageBox.Show("ana Da5lt ellog ");
                    User.SendPlayer(Myuser,streamWriter);


                    

                }

                     if (s=="showplayer")
                {
                    MessageBox.Show("ana Da5lt players ");
                  //  Console.WriteLine("ana Da5lt join ");

                    Console.WriteLine(streamReader.ReadString());
                    s = streamReader.ReadString();
                    //  MessageBox.Show("ana 3mlt recevie");
                    // Room ag = new Room(Myuser, "ahmed", "fsadf");
                   
                    while (s != "end")
                    {




                        User receivedpayer = User.Receiver(s);

                        players.Add(receivedpayer);
                        Console.WriteLine("I receive room!");
                        s = streamReader.ReadString();


                    }

                    Console.WriteLine("Yes i Do it ");
                }
                Console.WriteLine("reecive " + s);
                    if (s == "showRooms")
                {
                    MessageBox.Show("ana Da5lt rooms ");

                    Console.WriteLine("ana Da5lt join ");
                  
                    Console.WriteLine(streamReader.ReadString());
                        s = streamReader.ReadString();
                  //  MessageBox.Show("ana 3mlt recevie");
                    Room ag = new Room(Myuser, "ahmed", 5);
                    rooms.Add(ag);
                    while (s != "end")
                        {


                            Room receivedRoom = Room.ReceiveRoom(s);

                        rooms.Add(receivedRoom);
                        Console.WriteLine("I receive room!");
                            s = streamReader.ReadString();


                        }

                        Console.WriteLine("Yes i Do it ");
                    }
                    if (s == "create")
                    {
                        Console.WriteLine("AnaBreceive");
                        User.SendPlayer(CreatedRoom.Player1, streamWriter);

                        Console.WriteLine("Enter Id of Room");
                        //String Idroom = Console.ReadLine();
                        streamWriter.Write(CreatedRoom.id);
                        Console.WriteLine("Enter Size Of room");
                        //String size = Console.ReadLine();
                        streamWriter.Write(CreatedRoom.index.ToString());
                      
                        Room room = Room.ReceiveRoom(streamReader);
                        Console.WriteLine("I receive room!");

                        
                        Myuser.room = room;



                    /*
                     
                    ********* un commentny yastaaaaaaaaaaaaa*******************

                        Console.WriteLine("player1 playing");
                        Game.SendGame(Myuser.room.game, streamWriter);
                       // streamWriter.Write("player one played");
                        while (true)
                        {
                            // Console.WriteLine(streamReader.ReadString());

                            Console.WriteLine("Recived player2 playing");

                            Myuser.room.game= Game.Receiver(streamReader);
                            Console.WriteLine("send  player2 playing");
                            //streamWriter.Write("player one played");
                            Game.SendGame(Myuser.room.game, streamWriter);
                           
                        }

                    */

                    }

                    if (s == "join")
                    {
                        Console.WriteLine("Start Join");

                        Console.WriteLine("AnaBreceive");
                        User.SendPlayer(Myuser, streamWriter);

                        Console.WriteLine("Enter Id of Room");
                        String Idroom = Console.ReadLine();
                        streamWriter.Write(Idroom);

                        Room   room = Room.ReceiveRoom(streamReader);
                        Console.WriteLine("I receive room!");
                    Myuser.room = room;

                       Console.WriteLine("ana gamed");

                        Console.WriteLine("End Join");

                        while (true)
                        {
                            //Console.WriteLine(streamReader.ReadString());
                            //streamWriter.Write("player 2 played");
                            Console.WriteLine("Recived player1 playing");

                            Myuser.room.game = Game.Receiver(streamReader);
                            Console.WriteLine("send  player2 playing");
                            //streamWriter.Write("player one played");
                            Game.SendGame(Myuser.room.game, streamWriter);
                            Console.WriteLine("done Saving");
                        }

  

                    }




                    s = "";
                }
           
      
            //return 0;

        }
    }
}