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
        public HumanPlayer human;
        public AiPlayer ai;



        // Constructor
        public Game()
        {
            human = new HumanPlayer();
            ai = new AiPlayer();

        }


        // Memeber Methods 


        public void RunGame()
        {
            Weclome();

        }
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

        public void PlayerSelect()
        {
            Console.WriteLine("Enter 1 for Single Player mode, enter 2 for multiplayer mode.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine();
            }
            else
            {

            }




        }
        public string Player1ChooseName()
        {
            Console.WriteLine("Please enter your: ");
            Console.ReadLine();
            string player1Input = Console.ReadLine();

            return player1Input;
        }


        public string Player2ChooseName()
        {

        }

        // if single player, need a method for human V Ai attacks
        // if human v human need method for human V human ATTACK 
        // Will these methods be called in the PlayerSelect method???

    }
}
