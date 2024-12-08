namespace AOC24.DayEight;

public class D8PartTwo
{
    public int Solve()
    {
        DayEightInput inputClass = new DayEightInput();
        List<List<char>> input = inputClass.Getinput();
        if (input.Count == 0)
        {
            return -1;
        }   

        List<((int, int), char)> indexes = new List<((int, int), char)>();
        for (int row = 0; row < input.Count; row++)
        {
            for (int col = 0; col < input[row].Count; col++)
            {
                if (input[row][col] != '.')
                {
                    indexes.Add(((row, col), input[row][col]));
                }
            }
        }

        int res = 0;
        char[] distinctValues = indexes.GroupBy(t => t.Item2)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToArray();
        
        foreach (char c in distinctValues)
        {
            ((int, int), char)[] indexesOfChar = indexes.Where(t => t.Item2 == c).ToArray();
            res += indexesOfChar.Length;
            for (int i = 0; i < indexesOfChar.Length - 1; i++)
            {
                for (int ii = i + 1; ii < indexesOfChar.Length; ii++)
                {
                    (int, int) dif = (indexesOfChar[i].Item1.Item1 - indexesOfChar[ii].Item1.Item1,
                        indexesOfChar[i].Item1.Item2 - indexesOfChar[ii].Item1.Item2);

                    int multiplier = 1;
                    while (indexesOfChar[i].Item1.Item1 + dif.Item1 * multiplier >= 0 &&
                           indexesOfChar[i].Item1.Item1 + dif.Item1 * multiplier < input.Count &&
                           indexesOfChar[i].Item1.Item2 + dif.Item2 * multiplier >= 0 &&
                           indexesOfChar[i].Item1.Item2 + dif.Item2 * multiplier < input[0].Count)
                    {
                        if (distinctValues.Contains(
                                input[indexesOfChar[i].Item1.Item1 + dif.Item1 * multiplier][
                                    indexesOfChar[i].Item1.Item2 + dif.Item2 * multiplier]))
                        {
                            res--;
                        }
                        input[indexesOfChar[i].Item1.Item1 + dif.Item1 * multiplier][indexesOfChar[i].Item1.Item2 + dif.Item2 * multiplier] = '#';
                        multiplier++;
                    }
                    
                    multiplier = 1;
                    while (indexesOfChar[ii].Item1.Item1 - dif.Item1 * multiplier >= 0 &&
                           indexesOfChar[ii].Item1.Item1 - dif.Item1 * multiplier < input.Count &&
                           indexesOfChar[ii].Item1.Item2 - dif.Item2 * multiplier >= 0 &&
                           indexesOfChar[ii].Item1.Item2 - dif.Item2 * multiplier < input[0].Count)
                    {
                        if (distinctValues.Contains(
                                input[indexesOfChar[ii].Item1.Item1 - dif.Item1 * multiplier][
                                    indexesOfChar[ii].Item1.Item2 - dif.Item2 * multiplier]))
                        {
                            res--;
                        }
                        input[indexesOfChar[ii].Item1.Item1 - dif.Item1 * multiplier][indexesOfChar[ii].Item1.Item2 - dif.Item2 * multiplier] = '#';
                        multiplier++;
                    }
                }
            }
        }
        
        return input.SelectMany(t => t).Count(t => t == '#') + res;
    }
}