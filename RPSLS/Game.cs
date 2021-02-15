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
        public Player player1;
        public Player player2;



        // Constructor
        public Game()
        {
            //human = new HumanPlayer("John", "Rock");
            //ai = new AiPlayer();
        }

        // Memeber Methods 

        public void RunGame()
        {
            Weclome();
            PlayerSelect();

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
            string player1name = Player1ChooseName();
            player1 = new HumanPlayer(player1name);
            
            if (userInput == 1)
            {
                //create p2
                string aiPlayerName = AiPlayerChooseName();
                player2 = new AiPlayer(aiPlayerName);

            }
            else
            {
                string player2name = Player2ChooseName();
                player2 = new HumanPlayer(player2name);
            }
        }

        public string Player1ChooseName()
        {
            Console.WriteLine("Please enter your: ");
            string player1Input = Console.ReadLine();
            Console.WriteLine("Player1 name is {0}", player1Input);
            
            return player1Input;
        }

        public string Player2ChooseName()
        {
            Console.WriteLine("Player 2 enter your name:");
            string player2Input = Console.ReadLine();
            Console.WriteLine($"Player2 name is {player2Input}");

            return player2Input;
        }

        public string AiPlayerChooseName()
        {
            Console.WriteLine("What is your opponents name?:");
            string aiNameInput = Console.ReadLine();
            Console.WriteLine($"You are now facing of with {aiNameInput}...  prepare be destoyed!!!");
            
            return aiNameInput;
        }

        public void Play()
        {
            // while player ones score and player twos score is less than 3, continue the loop
            while (player1.score < 3)
            {
                // Make each palyer make their choice
                // Then comparethe gestures and increemnt the winning players score (compare gesture should be its own method)
            }
        }



        // Need to decide on how many rounds there wil lbe

    }
}
