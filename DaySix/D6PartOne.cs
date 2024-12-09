namespace AOC24.DaySix;

public class D6PartOne : IDays
{
    private int GetCount(List<List<char>> input)
    {
        int res = 0;
        foreach (var row in input)
        {
            foreach (var item in row)
            {
                if (item == 'X')
                {
                    res++;
                }
            }
        }

        return res + 1;
    }
    
    public long Solve()
    {
        List<List<char>> input;
        DaySixInput d6 = new DaySixInput();
        input = d6.GetInput();
        if (input.Count == 0)
        {
            return -1;
        }

        int res = 0;

        ((int, int) dir, (int, int) coords) = D6Utils.GetStartCoords(input, out char currChar);
        if (currChar == ' ')
        {
            return -1;
        }
        
        do
        {
            if (coords.Item1 + dir.Item1  < 0 || coords.Item1 + dir.Item1 >= input[0].Count || coords.Item2 + dir.Item2 < 0 || coords.Item2 + dir.Item2 >= input.Count)
            {
                break;
            }
            if (input[coords.Item1 + dir.Item1][coords.Item2 + dir.Item2] == '#')
            {
                dir = D6Utils.GetNextTurnDir(ref currChar);
            }
            else
            {
                input[coords.Item1][coords.Item2] = 'X';
                coords.Item1 += dir.Item1;
                coords.Item2 += dir.Item2;
                input[coords.Item1][coords.Item2] = currChar;
            }
        }
        while (true);

        res = GetCount(input);
        
        return res;
    }
}