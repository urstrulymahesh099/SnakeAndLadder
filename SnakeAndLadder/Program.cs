using SnakeAndLadder;
using System;
namespace SnakeAndLadder

{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem Statement?");
            Gameplay playerPosition = new Gameplay();
            playerPosition.Position();
            Gameplay dice = new Gameplay();
            dice.DiceRoll();

        }
    }
}