namespace DayOne;

public class PartTwo : IDayOne
{
    private List<int> _left;
    private List<int> _right;
    
    public PartTwo(List<int> left, List<int> right)
    {
        _left = left;
        _right = right;
    }
    
    public int Solve()
    {
        int result = 0;

        foreach (int num in _left)
        {
            result += _right.Count(n => n == num) * num;
        }
        
        return result;
    }
}