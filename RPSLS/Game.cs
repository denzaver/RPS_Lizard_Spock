using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {

        // Member Variables


        // Constructor
        public Game()
        {

        }


        // Memeber Methods 

        public void Weclome()
        {
            Console.WriteLine("Welcome to 'Rock, Paper, Siccors, Lizard, Spock!");
            Console.WriteLine("The rules are as follows: \n" +
                "Rock crushes Scissors, \n" +
                "Scissors cuts Paper, \n" +
                "Paper covers Rock, \n" +
                "Rock crushes Lizard, \n" +
                "Lizard poisons Spcok, \n" +
                "Spock smashes Scissors, \n" +
                "Scissors decapitates Lizard, \n" +
                "Lizard eats paper, \n" +
                "Paper discproves Spock, \n" +
                "Spock vaporizes Rock.");
        }

    }
}
