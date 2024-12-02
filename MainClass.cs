using AOC24.DayOne;
using AOC24.DayTwo;

namespace AOC24;

class MainClass
{
    static void Main(string[] args)
    {
        IDays d1PartOne = new D1PartOne();
        IDays d1PartTwo = new D1PartTwo();
        
        IDays d2PartOne = new D2PartOne();   
        IDays d2PartTwo = new D2PartTwo();  
        
        //Console.WriteLine("Day one, part one: " + d1PartOne.Solve());
        //Console.WriteLine("Day one, part two: " + d1PartTwo.Solve());
        //Console.WriteLine("Day two, part one: " + d2PartOne.Solve());
        //Console.WriteLine("Day two, part two: " + d2PartTwo.Solve());
    }
}