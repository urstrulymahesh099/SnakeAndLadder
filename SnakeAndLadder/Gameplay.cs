using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Gameplay
    {
        Random random = new Random();
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int playerPosition = 0, count = 0;

        public void Position()
        {
            Console.WriteLine("Lets Play!!!" + "\t" + "You are at - " + playerPosition);
        }
        public int DiceRoll()
        {
            int dice = random.Next(1, 7);
            Console.WriteLine("Output of Dice - " + dice);
            Console.WriteLine("You are at -", _ = this.playerPosition);
            count++;
            return dice;
        }
        public void Check()
        {
            while (playerPosition < WINNING_POSITION)
            {
                int ROLL = random.Next(0, 3);
                Console.WriteLine(ROLL);
                switch (ROLL)
                {
                    case NO_PLAY:
                        this.playerPosition += 0;
                        break;
                    case LADDER:
                        this.playerPosition += DiceRoll();
                        int die = DiceRoll();
                        if (this.playerPosition + die <=  WINNING_POSITION)
                            this.playerPosition += die;
                        break;
                    case SNAKE:
                        this.playerPosition -= DiceRoll();
                        break;
                        {
                            this.playerPosition = 0;
                        }
                        break;
                }
                Console.WriteLine("You Are At " + this.playerPosition);
            }
            Console.WriteLine("Count of dice PLAYED " + count);
            Console.WriteLine("You won the GAME");
        }
    }
}