namespace AOC24.DaySeven;

public class DaySevenInput
{
    public List<string> GetInput()
    {
        string path = "Input7.txt";
        return File.Exists(path) ? File.ReadAllLines(path).ToList() : new List<string>();
    }
}