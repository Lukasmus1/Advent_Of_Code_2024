namespace AOC24.DayTwelve;

public class DayTwelveInput
{
    public List<List<char>> GetInput()
    {
        string path = "Input12.txt";

        List<List<char>> input = new();
        if (File.Exists(path))
        {
            foreach (string s in File.ReadAllLines(path))
            {
                input.Add(s.ToCharArray().ToList());
            }
        }
        
        return input;
    }

}