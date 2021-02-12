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

        public override void ChooseGesture()  // the Human player CAN choose a gesture  
        {

        }

    }
}
