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

namespace AOC24;

class MainClass
{
    static void Main(string[] args)
    {
        Solver solver = new();
        
        //Most of these can be written better with abstract classes and such
        
        solver.Solve(new D1PartOne(), new D1PartTwo(), "one");
        
        solver.Solve(new D2PartOne(), new D2PartTwo(), "two");
        
        solver.Solve(new D3PartOne(), new D3PartTwo(), "three");
        
        //Could be done better with loops for example
        solver.Solve(new D4PartOne(), new D4PartTwo(), "four");
        
        solver.Solve(new D5PartOne(), new D5PartTwo(), "five");
        
        //This really isn't the best solution, tried to fix it, but I ran into a weird bug and decided to give up
        solver.Solve(new D6PartOne(), new D6PartTwo(), "six");
        
        //Part two could be done better, rn it's very slow
        solver.Solve(new D7PartOne(), new D7PartTwo(), "seven");
        
        solver.Solve(new D8PartOne(), new D8PartTwo(), "eight");
        
        solver.Solve(new D9PartOne(), new D9PartTwo(), "nine");
        
    }
}