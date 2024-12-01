namespace DayOne;

class MainClass
{
    static void Main(string[] args)
    {
        string path = "Input.txt";
        Console.WriteLine(Directory.GetCurrentDirectory());
        string[] nums;
        List<int> left = new();
        List<int> right = new();
        
        if (File.Exists(path))
        {
            nums = File.ReadAllLines(path);
        }
        else
        {
            return;
        }

        foreach (string row in nums)
        {
            string[] num = row.Split("   ");
            left.Add(int.Parse(num[0]));
            right.Add(int.Parse(num[1]));
        }
        
        IDayOne partOne = new PartOne(new List<int>(left), new List<int>(right));
        IDayOne partTwo = new PartTwo(left, right);
        
        Console.WriteLine("Part one: " + partOne.Solve());
        Console.WriteLine("Part two: " + partTwo.Solve());
    }
}