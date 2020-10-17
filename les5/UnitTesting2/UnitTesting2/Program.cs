using System;

namespace UnitTesting2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGame numbergame = new NumberGame();
            var score = numbergame.RateGuess(5);
            Console.WriteLine($"U score: {score}");
        }
    }
}
