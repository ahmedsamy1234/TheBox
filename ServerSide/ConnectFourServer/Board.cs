﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourServer
{
    public class Board
    {
        string size;
        string Color1;
        string Color2;
        int[][] State;

        public Board(string s)
        {
            size = s;
        }
    }
}
