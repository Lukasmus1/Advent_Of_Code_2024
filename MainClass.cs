using AOC24.DayFour;
using AOC24.DayOne;
using AOC24.DayTwo;
using AOC24.DayThree;

namespace AOC24;

class MainClass
{
    static void Main(string[] args)
    {
        D1PartOne d1PartOne = new D1PartOne();
        D1PartTwo d1PartTwo = new D1PartTwo();
        
        D2PartOne d2PartOne = new D2PartOne();   
        D2PartTwo d2PartTwo = new D2PartTwo();  
        
        D3PartOne d3PartOne = new D3PartOne();
        D3PartTwo d3PartTwo = new D3PartTwo();
        
        //Could be done better with loops for example
        D4PartOne d4PartOne = new D4PartOne();
        D4PartTwo d4PartTwo = new D4PartTwo();
        
        //Console.WriteLine("Day one, part one: " + d1PartOne.Solve());
        //Console.WriteLine("Day one, part two: " + d1PartTwo.Solve());
        //Console.WriteLine("Day two, part one: " + d2PartOne.Solve());
        //Console.WriteLine("Day two, part two: " + d2PartTwo.Solve());
        //Console.WriteLine("Day three, part one: " + d3PartOne.Solve());
        //Console.WriteLine("Day three, part two: " + d3PartTwo.Solve());
        //Console.WriteLine("Day four, part one: " + d4PartOne.Solve());
        //Console.WriteLine("Day four, part two: " + d4PartTwo.Solve());
    }
}