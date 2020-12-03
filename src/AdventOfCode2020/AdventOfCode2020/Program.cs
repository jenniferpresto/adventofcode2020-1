﻿using AdventOfCode2020.Challenges.Day01;
using AdventOfCode2020.Challenges.Day02;
using AdventOfCode2020.Challenges.Day03;
using System;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to erjicle's solutions to Advent of Code 2020!!---");
            // Day 1
            Console.WriteLine($"Day 01 - Part 1: {Day01.GetDay01Part01Answer()}");
            Console.WriteLine($"Day 01 - Part 2: {Day01.GetDay01Part02Answer()}");
            // Day 2
            Console.WriteLine($"Day 02 - Part 1: {Day02.GetDay02Part01Answer()}");
            Console.WriteLine($"Day 02 - Part 2: {Day02.GetDay02Part02Answer()}");
            // Day 3
            Console.WriteLine($"Day 03 - Part 1: {Day03.GetDay03Part01Answer()}");
            Console.WriteLine($"Day 03 - Part 2: {Day03.GetDay03Part02Answer()}");
        }
    }
}
