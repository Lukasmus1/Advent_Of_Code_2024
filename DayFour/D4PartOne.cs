namespace AOC24.DayFour;

public class D4PartOne :IDays
{
    public long Solve()
    {
        DayFourInput dayFourInput = new();
        List<List<char>>? input = dayFourInput.GetInput();
        if (input == null)
        {
            return -1;
        }

        int count = 0;

        bool left, right, up, down;
        for (int i = 0; i < input.Count; i++)
        {
            for (int j = 0; j < input[i].Count; j++)
            {
                if (input[i][j] == 'X')
                {
                    down = j + 3 < input[i].Count;
                    up = j - 3 >= 0;
                    right = i + 3 < input.Count;
                    left = i - 3 >= 0 ;

                    if (left)
                    {
                        if (input[i - 1][j] == 'M' && input[i - 2][j] == 'A' && input[i - 3][j] == 'S')
                        {
                            count++;
                        }
                        
                        if (up && input[i - 1][j - 1] == 'M' && input[i - 2][j - 2] == 'A' && input[i - 3][j - 3] == 'S')
                        {
                            count++;
                        }
                        
                        if (down && input[i - 1][j + 1] == 'M' && input[i - 2][j + 2] == 'A' && input[i - 3][j + 3] == 'S')
                        {
                            count++;
                        }
                    }

                    if (right)
                    {
                        if (input[i + 1][j] == 'M' && input[i + 2][j] == 'A' && input[i + 3][j] == 'S')
                        {
                            count++;
                        }
                        
                        if (up && input[i + 1][j - 1] == 'M' && input[i + 2][j - 2] == 'A' && input[i + 3][j - 3] == 'S')
                        {
                            count++;
                        }
                        
                        if (down && input[i + 1][j + 1] == 'M' && input[i + 2][j + 2] == 'A' && input[i + 3][j + 3] == 'S')
                        {
                            count++;
                        }
                    }
                    
                    if (up && input[i][j - 1] == 'M' && input[i][j - 2] == 'A' && input[i][j - 3] == 'S')
                    {
                        count++;
                    }
                    if (down && input[i][j + 1] == 'M' && input[i][j + 2] == 'A' && input[i][j + 3] == 'S')
                    {
                        count++;
                    }
                }
            }
        }
        return count;
    }
}