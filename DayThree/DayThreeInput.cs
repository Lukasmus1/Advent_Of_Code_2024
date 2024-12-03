namespace AOC24.DayThree;

public class DayThreeInput
{
    public string? GetInput()
    {
        string path = "Input3.txt";
        string input;
        if (File.Exists(path))
        {
            input = File.ReadAllText(path);
        }
        else
        {
            return null;
        }

        return input;
    }
}