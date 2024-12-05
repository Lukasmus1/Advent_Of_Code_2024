namespace AOC24.DayFive;

public class DayFiveInput
{
    public (List<(int, int)>, List<List<int>>) GetInput()
    {
        string path = "Input5.txt";
        if (!File.Exists(path))
        {
            return (new List<(int, int)>(), new List<List<int>>());
        }

        List<(int, int)> rules = new List<(int, int)>();
        List<List<int>> pages = new List<List<int>>();
        
        string[] input = File.ReadAllLines(path);

        int breakIndex = 0;
        foreach (string row in input)
        {
            if (!row.Contains('|'))
            {
                breakIndex = Array.IndexOf(input, row);
                break;
            }

            string[] splitRow = row.Split('|');
            rules.Add((int.Parse(splitRow[0]), int.Parse(splitRow[1])));
        }

        foreach (string row in input.Skip(breakIndex+1))
        {
            List<int> page = row.Split(',').Select(int.Parse).ToList();
            pages.Add(page);
        }
        
        return (rules, pages);
    }
}