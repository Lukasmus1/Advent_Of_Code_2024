namespace AOC24.DayTen;

public class D10PartTwo : IDays
{
    private static List<List<char>> _input = new();
    
    private static int Check(int row, int col, int num)
    {
        int res = 0;
        
        if (num == 10)
        {
            res++;
            return res;
        }
        
        if (row + 1 < _input.Count && _input[row + 1][col] == (num + '0'))
        {
            res += Check(row + 1, col, num + 1);
        }
        
        if (row - 1 >= 0 && _input[row - 1][col] == (num + '0'))
        {
            res += Check(row - 1, col, num + 1);
        }
        
        if (col + 1 < _input[row].Count && _input[row][col + 1] == (num + '0'))
        {
            res += Check(row, col + 1, num + 1);
        }
        
        if (col - 1 >= 0 && _input[row][col - 1] == (num + '0'))
        {
            res += Check(row, col - 1, num + 1);
        }

        return res;
    }
    
    public long Solve()
    {
        _input = new DayTenInput().GetInput();
        if (_input.Count == 0)
        {
            return -1;
        }
        
        int res = 0;

        //For each row
        for (int i = 0; i < _input.Count; i++)
        {
            //For each column in that row
            for (int ii = 0; ii < _input[i].Count; ii++)
            {
                if (_input[i][ii] != '0')
                {
                    continue;
                }
                
                res += Check(i, ii, 1);
            }    
        }

        return res;
    }
}