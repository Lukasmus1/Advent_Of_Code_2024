namespace DayOne;

public class PartOne : IDayOne
{
    private List<int> _left;
    private List<int> _right;
    
    public PartOne(List<int> left, List<int> right)
    {
        _left = left;
        _right = right;
    }
    
    public int Solve()
    {
        int result = 0;
        while (_left.Count > 0 && _right.Count > 0)
        {
            int num1 = _left.Min();
            int num2 = _right.Min();
            
            result += int.Abs(num1 - num2);
            _left.Remove(num1);
            _right.Remove(num2);
        }
        
        return result;
    }
}