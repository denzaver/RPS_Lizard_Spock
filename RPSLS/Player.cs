using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

    // Make this class an abstract class
    public abstract class Player
    {
        // Member Variables
        public string name;
        public string choice;
        public int score;
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


        // Make this method and abstract method signature. 
        // That will force the children classes to implement this method in their own way
        public abstract string ChooseGesture(); 



    }
}
