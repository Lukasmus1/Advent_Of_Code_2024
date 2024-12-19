using System.Diagnostics;
using AOC24.DayEight;
using AOC24.DayFour;
using AOC24.DayOne;
using AOC24.DayTwo;
using AOC24.DayThree;
using AOC24.DayFive;
using AOC24.DayNine;
using AOC24.DaySeven;
using AOC24.DaySix;
using AOC24.DayTen;
using AOC24.DayEleven;
using AOC24.DayTwelve;
using AOC24.DayThirteen;

namespace AOC24;

class MainClass
{
    private static void Solve(IDays partOne, IDays partTwo, string day)
    {
        Stopwatch sw = new();
        long res1, res2;
        
        sw.Start();
        res1 = partOne.Solve();
        res2 = partTwo.Solve();
        sw.Stop();
        
        Console.WriteLine($"Day {day}, part one: " + res1);
        Console.WriteLine($"Day {day}, part two: " + res2);
        Console.WriteLine("Time taken: " + sw.Elapsed.Seconds + "s " + sw.ElapsedMilliseconds + "ms");
        Console.WriteLine("-------------------------------------------------");
        sw.Reset();
    }
    
    static void Main(string[] args)
    {
        //Most of these can be written better with abstract classes and such
        /*
        Solve(new D1PartOne(), new D1PartTwo(), "one");
        
        Solve(new D2PartOne(), new D2PartTwo(), "two");
        
        Solve(new D3PartOne(), new D3PartTwo(), "three");
        
        //Could be done better with loops for example
        Solve(new D4PartOne(), new D4PartTwo(), "four");
        
        Solve(new D5PartOne(), new D5PartTwo(), "five");
        
        //This really isn't the best solution, tried to fix it, but I ran into a weird bug and decided to give up
        Solve(new D6PartOne(), new D6PartTwo(), "six");
        
        //Part two could be done better, rn it's very slow
        Solve(new D7PartOne(), new D7PartTwo(), "seven");
        
        Solve(new D8PartOne(), new D8PartTwo(), "eight");
        
        Solve(new D9PartOne(), new D9PartTwo(), "nine");
        
        Solve(new D10PartOne(), new D10PartTwo(), "ten");
        
        Solve(new Day11(25), new Day11(75), "eleven");
        
        Solve(new D12PartOne(), new D12PartTwo(), "twelve");*/
        
        Solve(new D13PartOne(), new DayThirteen.D13PartTwo(), "thirteen");
        
    }
}