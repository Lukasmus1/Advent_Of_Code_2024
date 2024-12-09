namespace AOC24.DayNine;

public class DayNineInput
{
    public List<string> GetInput()
    {
        string path = "Input9.txt";

        return File.Exists(path) ? File.ReadAllText(path).ToCharArray().Select(c => c.ToString()).ToList() : new List<string>();
    }
}