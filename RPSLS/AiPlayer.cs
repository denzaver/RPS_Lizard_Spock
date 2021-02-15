using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AiPlayer : Player
    {
        // Member Variables
        Random random;

        // Constructor
        public AiPlayer(string name)
        {
            this.name = name;
            random = new Random();
        }

        // Member Methods

        public override string ChooseGesture()  
        {
            int randomChoice = random.Next(gesture.Count);
            Console.WriteLine($" AI Player {name} has played {gesture[randomChoice]}");

            return gesture[randomChoice];
        }

        

        public  void PlayerScore()
        {

        }

    }
}
