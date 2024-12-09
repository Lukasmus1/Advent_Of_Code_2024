namespace AOC24.DayOne;

public class D1PartOne : IDays
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
        while (left.Count > 0 && right.Count > 0)
        {
            int num1 = left.Min();
            int num2 = right.Min();
            
            result += int.Abs(num1 - num2);
            left.Remove(num1);
            right.Remove(num2);
        }
        
        return result;
    }
}