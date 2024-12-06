namespace AOC24.DaySix;

public class D6Utils
{
    public static ((int, int), (int, int)) GetStartCoords(List<List<char>> input, out char currChar)
    {
        for (int i = 0; i < input.Count; i++)
        {
            for(int ii = 0; ii < input[i].Count; ii++)
            {
                switch (input[i][ii])
                {
                    case '^':
                        currChar = '^';
                        return ((-1, 0), (i, ii));
                    case 'v':
                        currChar = 'v';
                        return ((1, 0), (i, ii));
                    case '<':
                        currChar = '<';
                        return ((0, -1), (i, ii));
                    case '>':
                        currChar = '>';
                        return ((0, 1), (i, ii));
                    default:
                        continue;
                }
            }
        }
        
        currChar = ' ';
        return ((-2, -2), (-2, -2));
    }
    
    public static (int, int) GetNextTurnDir(ref char currChar)
    {
        switch (currChar)
        {
            case '^':
                currChar = '>';
                return (0, 1);
            case '>':
                currChar = 'v';
                return (1, 0);
            case 'v':
                currChar = '<';
                return (0, -1);
            case '<':
                currChar = '^';
                return (-1, 0);
            default:
                currChar = ' ';
                return (-2, -2);
            
        }
    }

    public static (int, int) GetNextDir(char c)
    {
        switch (c)
        {
            case '^':
                return (-1, 0);
            case '>':
                return (0, 1);
            case 'v':
                return (1, 0);
            case '<':
                return (0, -1);
            default:
                return (-2, -2);
        }
    }

}