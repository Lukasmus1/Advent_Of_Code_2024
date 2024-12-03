namespace AOC24.DayOne;

public class DayOneInput
{
    public (List<int>?, List<int>?) GetInput()
    {
        string path = "Input.txt";
        string[] nums;
        List<int> left = new();
        List<int> right = new();
        
        if (File.Exists(path))
        {
            nums = File.ReadAllLines(path);
        }
        else
        {
            return (null, null);
        }

        foreach (string row in nums)
        {
            string[] num = row.Split("   ");
            left.Add(int.Parse(num[0]));
            right.Add(int.Parse(num[1]));
        }
        
        return (left, right);
    }
}