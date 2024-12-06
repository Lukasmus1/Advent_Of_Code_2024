namespace AOC24.DaySix;

public class DaySixInput
{
    public List<List<char>> GetInput()
    {
        string path = "Input6.txt";
        List<List<char>> input = new List<List<char>>();
        
        if (!File.Exists(path))
        {
            return input;
        }
        
        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines)
        {
            input.Add(line.ToCharArray().ToList());
        }
        return input;
    }
}