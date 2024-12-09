namespace AOC24.DayEight;

public class D8PartOne : IDays
{
    public long Solve()
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

        foreach (char c in indexes.Select(t => t.Item2).Distinct())
        {
            ((int, int), char)[] indexesOfChar = indexes.Where(t => t.Item2 == c).ToArray(); 
            for (int i = 0; i < indexesOfChar.Length - 1; i++)
            {
                for (int ii = i + 1; ii < indexesOfChar.Length; ii++)
                {
                    (int, int) dif = (indexesOfChar[i].Item1.Item1 - indexesOfChar[ii].Item1.Item1,
                        indexesOfChar[i].Item1.Item2 - indexesOfChar[ii].Item1.Item2);

                    if (indexesOfChar[i].Item1.Item1 + dif.Item1 >= 0 &&
                        indexesOfChar[i].Item1.Item1 + dif.Item1 < input.Count &&
                        indexesOfChar[i].Item1.Item2 + dif.Item2 >= 0 &&
                        indexesOfChar[i].Item1.Item2 + dif.Item2 < input[0].Count)
                    {
                        input[indexesOfChar[i].Item1.Item1 + dif.Item1][indexesOfChar[i].Item1.Item2 + dif.Item2] = '#';
                    }
                    if (indexesOfChar[ii].Item1.Item1 - dif.Item1 >= 0 &&
                        indexesOfChar[ii].Item1.Item1 - dif.Item1 < input.Count &&
                        indexesOfChar[ii].Item1.Item2 - dif.Item2 >= 0 &&
                        indexesOfChar[ii].Item1.Item2 - dif.Item2 < input[0].Count)
                    {
                        input[indexesOfChar[ii].Item1.Item1 - dif.Item1][indexesOfChar[ii].Item1.Item2 - dif.Item2] = '#';
                    }   
                }
            }
        }
        
        return input.SelectMany(t => t).Count(t => t == '#');
    }
}