namespace AOC24.DayEight;

public class DayEightInput
{
    public List<List<char>> Getinput()
    {
        List<List<char>> input = new List<List<char>>();
        string[] unformattedInput;
        string path = "Input8.txt";

        if (File.Exists(path))
        {
            unformattedInput = File.ReadAllLines(path);
        }
        else
        {
            return new List<List<char>>();
        }
        
        foreach (string line in unformattedInput)
        {
            List<char> lineList = new List<char>();
            foreach (char c in line)
            {
                lineList.Add(c);
            }
            input.Add(lineList);
        }
        return input;
    }
}