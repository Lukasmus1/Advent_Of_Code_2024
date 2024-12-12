namespace AOC24.DayEleven;

public class DayElevenInput
{
    public Dictionary<string, long> GetInput()
    {
        string path = "Input11.txt";
        Dictionary<string, long> res = new();
        
        if (!File.Exists(path)) 
            return res;
        
        foreach (string s in File.ReadAllText(path).Split(" "))
        {
            if (!res.TryAdd(s, 1))
            {
                res.Add(s, res[s] + 1);
            }
        }

        return res;
    }
}