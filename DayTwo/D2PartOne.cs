namespace AOC24.DayTwo;

public class D2PartOne : IDays
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
    
    public int Solve()
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
            if ((IsAscending(report) || IsDescending(report)) && AdjacentSafe(report))
            {
                safeCount++;
            }
        }

        return safeCount;
    }
}