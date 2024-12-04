namespace AOC24.DayFour;

public class DayFourInput
{
    public List<List<char>>? GetInput()
    {
        List<List<char>> res = new();
        string path = "Input4.txt";
        string[] input;
        if (File.Exists(path))
        {
            input = File.ReadAllLines(path);
        }
        else
        {
            return null;
        }

        for(int i = 0; i < input.Length; i++)
        {
            res.Add(new List<char>());
            foreach (char c in input[i])
            {
                res[i].Add(c);
            }
        }
        
        return res;
    }
}