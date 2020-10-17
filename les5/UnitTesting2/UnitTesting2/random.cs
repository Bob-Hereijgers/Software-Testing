using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting2
{
    class Die
    {
        private static readonly Random Random = new Random();

        public int Roll()
        {
            return Random.Next(1, 6);
        }
    }

    public class NumberGame
    {
        private readonly Die _die;

        public NumberGame()
        {
            _die = new Die();
        }

        public int RateGuess(int guess)
        {
            var result = _die.Roll();

            if (result == guess)
            {
                return 2;
            }

            if (result - 1 == guess || result + 1 == guess)
            {
                return 1;
            }
            return 0;
        }
    }
}
