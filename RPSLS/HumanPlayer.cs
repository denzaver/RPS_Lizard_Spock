using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer : Player
    {
        // Member Variables

        // Constructor
        public HumanPlayer(string name)
        {
            this.name = name;



        }

        // Member Methods (CAN DO)

        public override void ChooseGesture()  // do i need to return the response? i dont need 
                                                    //to because its all happening within this class adn method?
        {
            Console.WriteLine("Select your gesture:");
            for (int i = 0; i < gesture.Count; i++)
            {
                Console.WriteLine($"Press {i} for {gesture[i]}");
            }
            string playerInput = Console.ReadLine();
            choice =  playerInput;


        }

        public void PlayerScore()
        {

        }

    }
}
