namespace AOC24.DaySeven;

public class D7PartOne : IDays
{
    public long Solve()
    {
        long res = 0;
        List<string> input = new DaySevenInput().GetInput();
        if (input.Count == 0)
        {
            return -1;
        }

        foreach (string row in input)
        {
            int indexOfColon = row.IndexOf(':');
            long result = long.Parse(row.Substring(0, indexOfColon));
            int[] nums = row.Substring(indexOfColon + 2).Split(' ').Select(int.Parse).ToArray();
            
            for (int i = 0; i < Math.Pow(2, nums.Length - 1); i++)
            {
                long currRes = nums[0];
                for (int ii = 0; ii < nums.Length - 1; ii++)
                {
                    if (((i >> ii) & 1) == 0)
                    {
                        currRes *= nums[ii + 1];
                    }
                    else
                    {
                        currRes += nums[ii + 1];
                    }
                }

                if (currRes == result)
                {
                    res += result;
                    break;
                }
            }
        }
        
        return res;
    }
}