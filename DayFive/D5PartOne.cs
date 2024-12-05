namespace AOC24.DayFive;

public class D5PartOne
{
    public int Solve()
    {
        int res = 0;
        DayFiveInput dayFiveInput = new DayFiveInput();
        (List<(int, int)> rules, List<List<int>> pages) = dayFiveInput.GetInput();
        if (rules.Count == 0 || pages.Count == 0)
        {
            return -1;
        }

        foreach (List<int> page in pages)
        {
            bool isPageValid = true;
            for (int i = 0; i < page.Count; i++)
            {
                foreach ((int, int) rule in rules)
                {
                    if (rule.Item1 == page[i])
                    {
                        int indexOfSecond = page.IndexOf(rule.Item2);

                        if (indexOfSecond != -1 && i > indexOfSecond)
                        {
                            isPageValid = false;
                            break;
                        }       
                    }
                }
            }

            if (isPageValid)
            {
                res += page[(page.Count-1)/2];
            }
        }
        return res;
    }
}