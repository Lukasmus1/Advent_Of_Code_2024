namespace AOC24.DayFour;

public class D4PartTwo
{
    public int Solve()
    {
        DayFourInput dayFourInput = new();
        List<List<char>>? input = dayFourInput.GetInput();
        if (input == null)
        {
            return -1;
        }

        int count = 0;
        
        for (int i = 0; i < input.Count; i++)
        {
            for (int j = 0; j < input[i].Count; j++)
            {
                if (input[i][j] == 'A')
                {
                    bool down = j + 1 < input[i].Count;
                    bool up = j - 1 >= 0;
                    bool right = i + 1 < input.Count;
                    bool left = i - 1 >= 0 ;

                    bool oneMas = false;
                    bool twoMas = false;
                    
                    if (left && right && up && down)
                    {
                        if (input[i - 1][j - 1] == 'M')
                        {
                            if (input[i + 1][j + 1] == 'S')
                            {
                                oneMas = true;
                            }
                        }
                        else if (input[i - 1][j - 1] == 'S')
                        {
                            if (input[i + 1][j + 1] == 'M')
                            {
                                oneMas = true;
                            }
                        }
                        
                        if (input[i + 1][j - 1] == 'M')
                        {
                            if (input[i - 1][j + 1] == 'S')
                            {
                                twoMas = true;
                            }
                        }
                        else if (input[i + 1][j - 1] == 'S')
                        {
                            if (input[i - 1][j + 1] == 'M')
                            {
                                twoMas = true;
                            }
                        }
                        
                        count += oneMas && twoMas ? 1 : 0;
                    }
                }
            }
        }
        return count;
    }
}