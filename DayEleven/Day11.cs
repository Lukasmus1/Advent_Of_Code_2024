namespace AOC24.DayEleven;

public class Day11(int iterCount) : IDays
{
    public long Solve()
    {
        Dictionary<string, int> input = new DayElevenInput().GetInput();
        if (input.Count == 0)
        {
            return -1;
        }

        Dictionary<string, (string, string)> mem = new();
        for (int iter = 0; iter < iterCount; iter++)
        {
            Dictionary<string, int> copy = new(input);
            foreach (KeyValuePair<string, int> t in copy)
            {
                for (int ii = 0; ii < t.Value; ii++)
                {
                    if (t.Key == "0")
                    {
                        if (input.TryGetValue("1", out int value))
                        {
                            input["1"] = value + 1;
                        }
                        else
                        {
                            input.Add("1", 1);
                        }
                    }
                    else if (t.Key.Length % 2 == 0)
                    {
                        string first;
                        string second;
                        if (mem.TryGetValue(t.Key, out (string, string) val))
                        {
                            first = val.Item1;
                            second = val.Item2;
                        }
                        else
                        {
                            int index = (int)(t.Key.Length * 0.5);
                            first = t.Key[..index].TrimStart('0');
                            second = t.Key[index..].TrimStart('0');
                            if (second == "")
                            {
                                second = "0";
                            }
                            mem.Add(t.Key, (first, second));
                        }
                        
                        if (input.TryGetValue(first, out int value))
                        {
                            input[first] = value + 1;
                        }
                        else
                        {
                            input.Add(first, 1);
                        }
                        
                        if (input.TryGetValue(second, out value))
                        {
                            input[second] = value + 1;
                        }
                        else
                        {
                            input.Add(second, 1);
                        }
                    }
                    else
                    {
                        if (mem.TryGetValue(t.Key, out (string, string) val))
                        {
                            if (input.TryGetValue(val.Item1, out int value))
                            {
                                input[val.Item1] = value + 1;
                            }
                            else
                            {
                                input.Add(val.Item1, 1);
                            }
                        }
                        else
                        {
                            string num = (long.Parse(t.Key) * 2024).ToString();
                            if (input.TryGetValue(num, out int value))
                            {
                                input[num] = value + 1;
                            }
                            else
                            {
                                input.Add(num, 1);
                            }
                            mem.Add(t.Key, (num, ""));
                        }
                    }
                    
                    input[t.Key] -= 1;
                    if (input[t.Key] == 0)
                    {
                        input.Remove(t.Key);
                    }
                }
            }
        }

        long res = 0;
        foreach (KeyValuePair<string,int> pair in input)
        {
            res += pair.Value;
        }

        return res;
    }
}