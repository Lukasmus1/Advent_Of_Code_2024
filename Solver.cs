using System.Diagnostics;

namespace AOC24;

public class Solver
{
    public void Solve(IDays partOne, IDays partTwo, string day)
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
}