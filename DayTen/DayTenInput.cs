namespace AOC24.DayTen;

public class DayTenInput
{
    public List<List<char>> GetInput()
    {
        string path = "Input10.txt";

        string[] lines;
        
        if (File.Exists(path))
        {
            lines = File.ReadAllLines(path);
        }
        else
        {
            return new List<List<char>>();
        }

        List<List<char>> input = new();
        foreach (string line in lines)
        {
            input.Add(line.ToCharArray().ToList());
        }
        
        return input;
    }
}