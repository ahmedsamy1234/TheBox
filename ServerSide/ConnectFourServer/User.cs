﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourServer
{
    public class User
    {
        public string username;
        public int Score;
        public bool IsRoomOwner;
        public bool IsPlayer;

        //        public ClientSocket socketconfig;
        public Room room;



        public string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        //  public ClientSocket Socketconfig { get => socketconfig; set => socketconfig = value; }

        public User(string name)
        {
            UserName = name;
            // socketconfig = new ClientSocket(4000);
            // this.score = 0;
            //this.isplayer = false;
            //this.isroomowner = false;
            //room = null;


        }

    }
}

