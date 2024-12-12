namespace AOC24.DayTwelve;

public class D12PartOne : IDays
{
    private static List<List<char>> _input = new();
    private static HashSet<(int, int)> _visited = new();

    private static (long, long) Next(int row, int col, char c)
    {
        long res = 0;
        long count = 0;
        if (!_visited.Add((row, col)))
        {
            return (res, count);
        }
        
        count = 1;
        
        bool left = row - 1 >= 0;
        bool right = row + 1 < _input[col].Count;
        bool up = col - 1 >= 0;
        bool down = col + 1 < _input.Count;

        if (right)
        {
            if (_input[col][row + 1] == c)
            {
                (long, long) tempRes = Next(row + 1, col, c);
                res += tempRes.Item1;
                count += tempRes.Item2;
            }
            else
            {
                res += 1;
            }

            if (down && _input[col + 1][row + 1] == c)
            {
                (long, long) tempRes = Next(row + 1, col + 1, c);
                res += tempRes.Item1;
                count += tempRes.Item2;
            }
        }
        else
        {
            res += 1;
        }

        if (down)
        {
            if (_input[col + 1][row] == c)
            {
                (long, long) tempRes = Next(row, col + 1, c);
                res += tempRes.Item1;
                count += tempRes.Item2;
            }
            else
            {
                res += 1;
            }

            if (left && _input[col + 1][row - 1] == c)
            {
                (long, long) tempRes = Next(row - 1, col + 1, c);
                res += tempRes.Item1;
                count += tempRes.Item2;
            }
        }
        else
        {
            res += 1;
        }

        if (left)
        {
            if (_input[col][row - 1] == c)
            {
                (long, long) tempRes = Next(row - 1, col, c);
                res += tempRes.Item1;
                count += tempRes.Item2;
            }
            else
            {
                res += 1;
            }

            if (up && _input[col - 1][row - 1] == c)
            {
                (long, long) tempRes = Next(row - 1, col - 1, c);
                res += tempRes.Item1;
                count += tempRes.Item2;
            }
        }
        else
        {
            res += 1;
        }

        if (up)
        {
            if (_input[col - 1][row] == c)
            {
                (long, long) tempRes = Next(row, col - 1, c);
                res += tempRes.Item1;
                count += tempRes.Item2;
            }
            else
            {
                res += 1;
            }

            if (right && _input[col - 1][row + 1] == c)
            {
                (long, long) tempRes = Next(row + 1, col - 1, c);
                res += tempRes.Item1;
                count += tempRes.Item2;
            }
        }
        else
        {
            res += 1;
            
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
                (long tempRes, long tempCount) = Next(row, col, _input[col][row]);
                res += tempRes * tempCount;
            }
        }

        return res;
    }
}