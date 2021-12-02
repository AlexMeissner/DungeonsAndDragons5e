using System;
using System.Collections.Generic;
using System.Linq;
using RestAPI.Models;

namespace RestAPI.Utility
{
    public enum Dice
    {
        D4,
        D6,
        D8,
        D10,
        D12,
        D20,
        D100
    }

    public static class DiceRoller
    {
        private static Random RandomGenerator = new();

        public static void SetSeed(int seed)
        {
            RandomGenerator = new(seed);
        }

        public static RollDice RollDice(Dice die)
        {
            int minimalRoll = GetMinimalValue(die);
            int maximalRoll = GetMaximalValue(die);
            int value = RandomGenerator.Next(minimalRoll, maximalRoll + 1);

            RollDice rollDice = new();
            rollDice.Result = (die == Dice.D100) ? value * 10 : value;
            rollDice.Results = new();

            for (int i = 0; i < maximalRoll - minimalRoll + 1; ++i)
            {
                rollDice.Results.Add(i < value);
            }

            rollDice.Results = rollDice.Results.OrderBy(x => RandomGenerator.Next()).ToList();

            return rollDice;
        }

        private static int GetMinimalValue(Dice die)
        {
            return die switch
            {
                Dice.D4 => 1,
                Dice.D6 => 1,
                Dice.D8 => 1,
                Dice.D10 => 0,
                Dice.D12 => 1,
                Dice.D20 => 1,
                Dice.D100 => 0,
                _ => 0,
            };
        }

        private static int GetMaximalValue(Dice die)
        {
            return die switch
            {
                Dice.D4 => 4,
                Dice.D6 => 6,
                Dice.D8 => 8,
                Dice.D10 => 9,
                Dice.D12 => 12,
                Dice.D20 => 20,
                Dice.D100 => 9,
                _ => 0,
            };
        }

        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> target)
        {
            return target.OrderBy(x => (RandomGenerator.Next()));
        }
    }
}