﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors 
{
    internal class Rock : pickObject
    {
        public int Flag { get; set; }
        int randpick;

        public Rock(int randpick)
        {
            this.randpick = randpick;
        }

        public string AnnouncePick()
        {
            if (randpick == 0)
            {
                return "Your opponent picked rock!";
            }
            else if (randpick == 1)
            {
                return "Your opponent picked paper!";
            }
            else
            {
                return "Your opponent picked scissors!";
            }
        }

        public string Test()
        {
            if (randpick == 0)
            {
                Flag = 2;
                Console.ForegroundColor = ConsoleColor.Blue;
                return "It's a tie!";
            }
            else if (randpick == 1)
            {
                Flag = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                return "You lost this round!";
            }
            else
            {
                Flag = 1;
                Console.ForegroundColor = ConsoleColor.Green;
                return "You won this round!";
            }
        }
    }
}
