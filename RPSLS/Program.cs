﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            //game.PlayerSelect();
            //game.Player1ChooseName();
            //game.RunGame();

            //HumanPlayer player = new HumanPlayer("john");
            //player.ChooseGesture();

            AiPlayer ai = new AiPlayer("joe");
            ai.ChooseGesture();



            Console.ReadLine();
        }
    }
}
