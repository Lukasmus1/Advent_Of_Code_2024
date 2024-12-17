namespace AOC24.DayTwelve;

public class D12PartTwo : IDays
{
    private static List<List<char>> _input = new();
    private static HashSet<(int, int)> _visited = new();

    private static (long, long) Next(int row, int col, char c, ushort dir)
    {
        long res = 0;
        long count = 0;
        if (!_visited.Add((row, col)))
        {
            return (res, count);
        }
        
        count = 1;

        switch (dir)
        {
            case 0:
                bool right = row + 1 < _input[col].Count;
                if (right && _input[col][row + 1] == c)
                {
                    (long tempRes, long tempCount) = Next(row + 1, col, c, 0);
                    res = tempRes;
                    count += tempCount;
                }
                else
                {
                    res = 1;
                }
                break;
            
            case 1:
                bool down = col + 1 < _input.Count;
                if (down && _input[col + 1][row] == c)
                {
                    (long tempRes, long tempCount) = Next(row, col + 1, c, 1);
                    res = tempRes;
                    count += tempCount;
                }
                else
                {
                    res = 1;
                }
                break;
            
            case 2:
                bool left = row - 1 >= 0;
                if (left && _input[col][row - 1] == c)
                {
                    (long tempRes, long tempCount) = Next(row - 1, col, c, 2);
                    res = tempRes;
                    count += tempCount;
                }
                else
                {
                    res = 1;
                }
                break;
            
            case 3:
                bool up = col - 1 >= 0;
                if (up && _input[col - 1][row] == c)
                {
                    (long tempRes, long tempCount) = Next(row, col - 1, c, 3);
                    res = tempRes;
                    count += tempCount;
                }
                else
                {
                    res = 1;
                }
                break;
        }

        return (res, count);
    }

    public long Solve()
    {
        _input = new DayTwelveInput().GetInput();
        if (_input.Count == 0)
        {
            return -1;
        }
        
        long res = 0;
        
        for (int col = 0; col < _input.Count; col++)
        {
            for (int row = 0; row < _input[col].Count; row++)
            {
                long tempRes = 0;
                long tempCount = 0;
                for (ushort i = 0; i < 4; i++)
                {
                    (tempRes, tempCount) = Next(row, col, _input[col][row], i);
                    res += tempRes;
                    Console.WriteLine(tempRes);
                }
                _visited.Clear();
            }
        }

        return res;
    }
}