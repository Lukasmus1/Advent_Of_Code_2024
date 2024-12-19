using System.Runtime.CompilerServices;

namespace AOC24.DayThirteen;

public class D13PartOne : IDays
{
    public long Solve()
    {
        List<(int, int)> buttonA = new();
        List<(int, int)> buttonB = new();
        List<(int, int)> results = new();
        (buttonA, buttonB, results) = new Day13Input().GetInput();
        if (buttonA.Count == 0 || buttonB.Count == 0 || results.Count == 0)
        {
            return -1;
        }
        
        long res = 0;

        for (int resIndex = 0; resIndex < results.Count; resIndex++)
        {
            int lowestTokenCost = 0;
            
            for (int i = 0; i < 100; i++)
            {
                int partRes = 0;
                int a = 0;
                int b = 0;
                
                bool tooHigh = false;
                while (a < 100 - i)
                {
                    partRes += buttonA[resIndex].Item1;
                    if (partRes == results[resIndex].Item1 && lowestTokenCost > 3 * a)
                    {
                        lowestTokenCost = 3 * a;
                        break;
                    }
                    else if (partRes > results[resIndex].Item1)
                    {
                        tooHigh = true;
                        break;
                    }
                    a++;
                }
                
                if (tooHigh)
                {
                    continue;
                }
                
                
                while (b < 100 - i)
                {
                    partRes += buttonA[resIndex].Item1;
                    if (partRes == results[resIndex].Item2 && lowestTokenCost > b)
                    {
                        lowestTokenCost = b;
                        break;
                    }
                    else if (partRes > results[resIndex].Item2)
                    {
                        tooHigh = true;
                        break;
                    }
                    b++;
                }
            }
            
            res += lowestTokenCost;
        }
        
        
        
        return res;
    }
}