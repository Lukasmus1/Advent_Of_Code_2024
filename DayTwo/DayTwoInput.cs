namespace AOC24.DayTwo;

public class DayTwoInput
{
    public List<List<int>>? GetInput()
    {
        string path = "Input2.txt";
        Console.WriteLine(Directory.GetCurrentDirectory());
        string[] nums;
        List<List<int>>? res = new List<List<int>>();
        
        if (File.Exists(path))
        {
            nums = File.ReadAllLines(path);
        }
        else
        {
            return null;
        }

        foreach (string line in nums)
        {
            List<int> row = line.Split(" ").Select(int.Parse).ToList();
            
            res.Add(row);
        }
        
        return res;
    }
}