namespace AOC24.DaySix;

public class D6PartTwo
{
    private bool IsInCycle((int, int) coords, (int, int) dir, List<List<char>> input, char currChar, HashSet<((int, int), char)> visited)
    {
        visited.Clear();
        do
        {
            if (coords.Item1 + dir.Item1 < 0 || coords.Item1 + dir.Item1 >= input[0].Count || coords.Item2 + dir.Item2 < 0 || coords.Item2 + dir.Item2 >= input.Count)
            {
                visited.Add((coords, currChar));
                break;
            }

            if (input[coords.Item1 + dir.Item1][coords.Item2 + dir.Item2] == '#')
            {
                dir = D6Utils.GetNextTurnDir(ref currChar);
            }
            else
            {
                if (!visited.Add((coords, currChar)))
                {
                    return true;
                }
                coords.Item1 += dir.Item1;
                coords.Item2 += dir.Item2;
                input[coords.Item1][coords.Item2] = currChar;
            }
        }
        while (true);

        return false;
    }

    public int Solve()
    {
        DaySixInput d6 = new DaySixInput();
        List<List<char>> input = d6.GetInput();
        if (input.Count == 0)
        {
            return -1;
        }

        HashSet<(int, int)> res = new HashSet<(int, int)>();

        ((int, int) dir, (int, int) coords) = D6Utils.GetStartCoords(input, out char currChar);
        if (currChar == ' ')
        {
            return -1;
        }

        HashSet<((int, int), char)> visited = new HashSet<((int, int), char)>();

        if (IsInCycle(coords, dir, input, currChar, visited))
        {
            return -1;
        }

        HashSet<((int, int), char)> visitedCycle = new HashSet<((int, int), char)>();
        foreach (((int, int), char) visitedVal in visited)
        {
            (int, int) nextDir = D6Utils.GetNextDir(visitedVal.Item2);
            if (visitedVal.Item1.Item1 + nextDir.Item1 < 0 || visitedVal.Item1.Item1 + nextDir.Item1 >= input[0].Count || visitedVal.Item1.Item2 + nextDir.Item2 < 0 || visitedVal.Item1.Item2 + nextDir.Item2 >= input.Count)
            {
                continue;
            }
            input[visitedVal.Item1.Item1 + nextDir.Item1][visitedVal.Item1.Item2 + nextDir.Item2] = '#';

            if (IsInCycle(coords, dir, input, currChar, visitedCycle))
            {
                res.Add((visitedVal.Item1.Item1 + nextDir.Item1, visitedVal.Item1.Item2 + nextDir.Item2));
            }

            visitedCycle.Clear();
            input[visitedVal.Item1.Item1 + nextDir.Item1][visitedVal.Item1.Item2 + nextDir.Item2] = '.';
        }

        return res.Count;
    }
}