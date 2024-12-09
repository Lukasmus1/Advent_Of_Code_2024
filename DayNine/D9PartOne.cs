using System.Text;

namespace AOC24.DayNine;

public class D9PartOne : IDays
{
    public long Solve()
    {
        List<string> input = new DayNineInput().GetInput();
        
        if (input.Count == 0)
        {
            return -1;
        }
        long res = 0;

        Queue<int> indexesOfEmpty = new();
        Stack<int> indexesOfChar = new();
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
                    indexesOfEmpty.Enqueue(i + ii);
                }
                else
                {
                    input.Insert(i, id.ToString());
                    indexesOfChar.Push(i + ii);
                }

                ii++;
            }

            i += ii - 1;            
            id = emptySpace ? id : id + 1;
            emptySpace = !emptySpace;
        }
        
        while (indexesOfChar.Peek() > indexesOfEmpty.Peek())
        {
            int indexOfChar = indexesOfChar.Pop();
            input[indexesOfEmpty.Dequeue()] = input[indexOfChar];
            input[indexOfChar] = ".";
        }

        for (int i = 0; input[i] != "."; i++)
        {
            res += long.Parse(input[i]) * i;
        }
        
        return res;
    }
}