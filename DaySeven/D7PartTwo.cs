using System.Text;

namespace AOC24.DaySeven;

public class D7PartTwo
{

    private void ConvertToTernary(int num, int length, ref StringBuilder res)
    {
        do
        {
            res.Append(num % 3);
            num /= 3;
        }
        while (num > 0);

        while (res.Length < length)
        {
            res.Append('0');
        }
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
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < Math.Pow(3, nums.Length - 1); i++)
            {
                long currRes = long.Parse(nums[0]);
                for (int ii = 0; ii < nums.Length - 1; ii++)
                {
                    ConvertToTernary(i, ii + 1, ref sb); 
                    
                    if (sb[ii] == '0')
                    {
                        currRes *= long.Parse(nums[ii + 1]);
                    }
                    else if (sb[ii] == '1')
                    {
                        currRes += long.Parse(nums[ii + 1]);
                    }
                    else
                    {
                        sb.Clear();
                        sb.Append(currRes);
                        sb.Append(nums[ii + 1]);
                        currRes = long.Parse(sb.ToString());
                    }

                    sb.Clear();
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