using System.Text.RegularExpressions;

namespace AOC24.DayThree;

public class D3PartTwo : IDays
{
    public long Solve()
    {
        DayThreeInput input = new DayThreeInput();
        string? data = input.GetInput();
        
        if (data == null)
        {
            return -1;
        }
        
        int res = 0;
        Regex pattern = new Regex(@"(mul\(\d{1,3},\d{1,3}\)|do\(\)|don't\(\))");
        MatchCollection matches = pattern.Matches(data);

        bool doFlag = true;
        foreach (Match match in matches)
        {
            if (match.Value == "do()")
            {
                doFlag = true;
            }
            else if (match.Value == "don't()")
            {
                doFlag = false;
            }
            else if (doFlag)
            {
                string[] values = match.Value.Split(",");
                int a = int.Parse(values[0].Substring(4));
                int b = int.Parse(values[1].Substring(0, values[1].Length - 1));
                res += a * b;
            }
        }
        
        return res;
    }
}