using System.Diagnostics;
using AOC24.DayEight;
using AOC24.DayFour;
using AOC24.DayOne;
using AOC24.DayTwo;
using AOC24.DayThree;
using AOC24.DayFive;
using AOC24.DaySeven;
using AOC24.DaySix;

namespace AOC24;

class MainClass
{
    static void Main(string[] args)
    {
        //Most of these can be written better with abstract classes and such
        
        D1PartOne d1PartOne = new D1PartOne();
        D1PartTwo d1PartTwo = new D1PartTwo();
        
        D2PartOne d2PartOne = new D2PartOne();   
        D2PartTwo d2PartTwo = new D2PartTwo();  
        
        D3PartOne d3PartOne = new D3PartOne();
        D3PartTwo d3PartTwo = new D3PartTwo();
        
        //Could be done better with loops for example
        D4PartOne d4PartOne = new D4PartOne();
        D4PartTwo d4PartTwo = new D4PartTwo();
        
        D5PartOne d5PartOne = new D5PartOne();
        D5PartTwo d5PartTwo = new D5PartTwo();
        
        //This really isn't the best solution, tried to fix it, but I ran into a weird bug and decided to give up
        D6PartOne d6PartOne = new D6PartOne();
        D6PartTwo d6PartTwo = new D6PartTwo();
        
        D7PartOne d7PartOne = new D7PartOne();
        //Could be done better, rn it's very slow
        D7PartTwo d7PartTwo = new D7PartTwo();
        
        D8PartOne d8PartOne = new D8PartOne();
        D8PartTwo d8PartTwo = new D8PartTwo();
        
        //Console.WriteLine("Day one, part one: " + d1PartOne.Solve());
        //Console.WriteLine("Day one, part two: " + d1PartTwo.Solve());
        //Console.WriteLine("Day two, part one: " + d2PartOne.Solve());
        //Console.WriteLine("Day two, part two: " + d2PartTwo.Solve());
        //Console.WriteLine("Day three, part one: " + d3PartOne.Solve());
        //Console.WriteLine("Day three, part two: " + d3PartTwo.Solve());
        //Console.WriteLine("Day four, part one: " + d4PartOne.Solve());
        //Console.WriteLine("Day four, part two: " + d4PartTwo.Solve());
        //Console.WriteLine("Day five, part one: " + d5PartOne.Solve());
        //Console.WriteLine("Day five, part two: " + d5PartTwo.Solve());
        //Console.WriteLine("Day six, part one: " + d6PartOne.Solve());
        //Console.WriteLine("Day six, part two: " + d6PartTwo.Solve());
        //Console.WriteLine("Day seven, part one: " + d7PartOne.Solve());
        //Console.WriteLine("Day seven, part two: " + d7PartTwo.Solve());
        //Console.WriteLine("Day eight, part one: " + d8PartOne.Solve());
        //Console.WriteLine("Day eight, part two: " + d8PartTwo.Solve());
    }
}