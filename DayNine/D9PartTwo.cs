namespace AOC24.DayNine;

public class D9PartTwo : IDays
{
    public long Solve()
    {
        List<string> input = new DayNineInput().GetInput();
        
        if (input.Count == 0)
        {
            return -1;
        }
        long res = 0;

        List<(int, int)> indexesOfEmpty = new();
        Stack<(int, int)> indexesOfChar = new();
        int id = 0;
        bool emptySpace = false;
        for (int i = 0; i < input.Count; i++)
        {
            int numValue = int.Parse(input[i]);
            input.RemoveAt(i);
            int ii = 0;
            while (ii < numValue)
            {
                if (emptySpace)
                {
                    input.Insert(i, ".");
                }
                else
                {
                    input.Insert(i, id.ToString());
                }
                ii++;
            }

            if (emptySpace)
            {
                indexesOfEmpty.Add((i, i + ii - 1));
            }
            else
            {
                indexesOfChar.Push((i, i + ii - 1));
            }
            
            i += ii - 1;            
            id = emptySpace ? id : id + 1;
            emptySpace = !emptySpace;
        }

        //Console.WriteLine(String.Join(" ", input));

        foreach ((int, int) charIndex in indexesOfChar)
        {
            int charLen = charIndex.Item2 + 1 - charIndex.Item1;
            for(int i = 0; i < indexesOfEmpty.Count; i++)
            {
                if (charIndex.Item1 < indexesOfEmpty[i].Item1)
                {
                    continue;
                }
                
                int emptyLen = indexesOfEmpty[i].Item2 + 1 - indexesOfEmpty[i].Item1;
                if (charLen <= emptyLen)
                {
                    for (int ii = 0; ii < charLen; ii++)
                    {
                        input[indexesOfEmpty[i].Item1 + ii] = input[charIndex.Item1 + ii];
                        input[charIndex.Item1 + ii] = ".";
                    }
                    
                    indexesOfEmpty[i] = (indexesOfEmpty[i].Item1 + charLen, indexesOfEmpty[i].Item2);
                    break;
                }
            }
        }
        
        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] == ".")
            {
                continue;
            }
            res += long.Parse(input[i]) * i;
        }
        
        return res;
    }
}