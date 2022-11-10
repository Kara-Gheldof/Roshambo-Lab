using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Lab
{

    enum Roshambo
    {
        Rock,
        Paper,
        Scissors
    }
    public abstract class Player
    {
        public abstract string Name { get; set; }
        public abstract string RoshamboValue { get; set; }

        
        string GenerateRoshambo (string roshamboValue)
        { 
            RoshamboValue = roshamboValue;
            return GenerateRoshambo (RoshamboValue);
        }

        public class RockPlayer : Player
        {
            public string RoshamboValue { get; set; }
             
        }

        public class RandomPlayer : Player
        {
            public string RoshamboValue { get; set; }
        }

        public class HumanPlayer : Player
        {
            public string RoshamboValue { get; set; }
        }
    }
}
