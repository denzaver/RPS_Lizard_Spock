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

        public override void ChooseGesture()  
        {
            

        }

        

        public  void PlayerScore()
        {

        }

    }
}
