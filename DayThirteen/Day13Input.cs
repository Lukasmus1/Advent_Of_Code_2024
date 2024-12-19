namespace AOC24.DayThirteen;

public class Day13Input
{
    //A, B, RES
    public (List<(int, int)>, List<(int, int)>, List<(int, int)>) GetInput()
    {
        string path = "Input13";
        if (!File.Exists(path))
        {
            return (new List<(int, int)>(), new List<(int, int)>(), new List<(int, int)>());
        }

        List<(int, int)> a = new();
        List<(int, int)> b = new();
        List<(int, int)> res = new();
        foreach (string s in File.ReadAllText(path).Split("\n\n"))
        {
            string[] split = s.Split('\n');
            string[] splitNum = split[0].Split(',');
            int numOne = int.Parse(splitNum[0][12..]);
            int numTwo = int.Parse(splitNum[1][2..]);
            a.Add((numOne, numTwo));
            
            splitNum = split[1].Split(',');
            numOne = int.Parse(splitNum[0][12..]);
            numTwo = int.Parse(splitNum[1][2..]);
            b.Add((numOne, numTwo));
            
            splitNum = split[2].Split(',');
            numOne = int.Parse(splitNum[0][9..]);
            numTwo = int.Parse(splitNum[1][3..]);
            res.Add((numOne, numTwo));
        }
        
        return (a, b, res);
    }
}