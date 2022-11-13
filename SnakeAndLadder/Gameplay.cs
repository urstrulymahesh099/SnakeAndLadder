using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Gameplay
    {
        public void Position()
        {
            int playerPosition = 0;
            Console.WriteLine("Lets Play");
            Console.WriteLine("You are at " + playerPosition);
            Console.WriteLine("Lets Roll");
        }
        public void DiceRoll()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("Result of Dice" + "\n"+dice);
        }
    }
}