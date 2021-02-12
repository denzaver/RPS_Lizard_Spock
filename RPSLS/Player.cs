using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        // Member Variables
        public string name;
        public string choice;
        public List<string> gesture;

        // Constructor
        public Player()
        {
            gesture = new List<string>();
            gesture.Add("rock");
            gesture.Add("paper");
            gesture.Add("siccors");
            gesture.Add("lizard");
            gesture.Add("spock");

        }

        // Member Methods


    }
}
