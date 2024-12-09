namespace AOC24.DayOne;

public class D1PartTwo : IDays
{
    public long Solve()
    {
        List<int>? left;
        List<int>? right;
        DayOneInput input = new();
        (left, right) = input.GetInput();
        
        if (left == null || right == null)
        {
            return -1;
        }
        
        int result = 0;

        foreach (int num in left)
        {
            result += right.Count(n => n == num) * num;
        }
        
        return result;
    }
}