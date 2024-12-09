namespace AOC24.DayTwo;

public class D2PartTwo : IDays
{
    private static bool IsDescending(List<int> report)
    {
        for (int i = report.Count - 1; i > 0; i--)
        {
            if (report[i] >= report[i - 1])
            {
                return false;
            }
        }
        
        return true;
    }

    private static bool IsAscending(List<int> report)
    {
        for (int i = 0; i < report.Count - 1; i++)
        {
            if (report[i] >= report[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    private static bool AdjacentSafe(List<int> report)
    {
        for (int i = 0; i < report.Count - 1; i++)
        {
            int val = Math.Abs(report[i] - report[i + 1]);
            if (val < 1 || val > 3)
            {
                return false;
            }
        }
        
        return true;
    }
    
    public long Solve()
    {
        DayTwoInput dayTwoInput = new();
        List<List<int>>? input = dayTwoInput.GetInput();
        if (input == null)
        {
            return -1;
        }
        
        int safeCount = 0;

        foreach (List<int> report in input)
        {
            List<int> reportCopy = new(report);
            
            for (int i = -1; i < report.Count; i++)
            {
                if (i >= 0)
                {
                    reportCopy = new List<int>(report);
                    reportCopy.RemoveAt(i);
                }

                if ((IsAscending(reportCopy) || IsDescending(reportCopy)) && AdjacentSafe(reportCopy))
                {
                    safeCount++;
                    break;
                }
                
            }
        }

        return safeCount;
    }
}