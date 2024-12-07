namespace AOC24.DaySeven;

public class D7PartTwo
{
    private string ConvertToTernary(int num, int length)
    {
        string res = "";
        do
        {
            res += num % 3;
            num /= 3;
        }
        while (num > 0) ;
        
        for(int i = res.Length; i < length; i++)
        {
            res += "0";
        }
        
        return res;
    }

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
            string[] nums = row.Substring(indexOfColon + 2).Split(' ').ToArray();
            
            for (int i = 0; i < Math.Pow(3, nums.Length - 1); i++)
            {
                long currRes = long.Parse(nums[0]);
                for (int ii = 0; ii < nums.Length - 1; ii++)
                {
                    string currNum = ConvertToTernary(i, nums.Length - 1); 
                    
                    if (currNum[ii] == '0')
                    {
                        currRes *= long.Parse(nums[ii + 1]);
                    }
                    else if (currNum[ii] == '1')
                    {
                        currRes += long.Parse(nums[ii + 1]);
                    }
                    else
                    {
                        currRes = long.Parse(currRes + nums[ii + 1]);
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