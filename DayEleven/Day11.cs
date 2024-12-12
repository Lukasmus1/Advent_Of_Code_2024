namespace AOC24.DayEleven;

public class Day11(int iterCount) : IDays
{
    public long Solve()
    {
        Dictionary<string, long> input = new DayElevenInput().GetInput();
        if (input.Count == 0)
        {
            return -1;
        }

        Dictionary<string, (string, string)> mem = new();
        Dictionary<string, long> toAdd = new();
        Dictionary<string, long> toRemove = new();
        for (int iter = 0; iter < iterCount; iter++)
        {
            Dictionary<string, long> copy = new(input);
            toAdd.Clear();
            toRemove.Clear();
            
            foreach (KeyValuePair<string, long> t in copy)
            {
                if (t.Key == "0")
                {
                    if (toAdd.TryGetValue("1", out long value))
                    {
                        toAdd["1"] = value + t.Value;
                    }
                    else
                    {
                        toAdd.Add("1", t.Value);
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
                        first = t.Key[..index];
                        second = t.Key[index..].TrimStart('0');
                        if (second == "")
                        {
                            second = "0";
                        }
                        mem.Add(t.Key, (first, second));
                    }

                    if (toAdd.TryGetValue(first, out long value))
                    {
                        toAdd[first] = value + t.Value;
                    }
                    else
                    {
                        toAdd.Add(first, t.Value);
                    }

                    if (toAdd.TryGetValue(second, out value))
                    {
                        toAdd[second] = value + t.Value;
                    }
                    else
                    {
                        toAdd.Add(second, t.Value);
                    }
                }
                else
                {
                    if (mem.TryGetValue(t.Key, out (string, string) val))
                    {
                        if (toAdd.TryGetValue(val.Item1, out long value))
                        {
                            toAdd[val.Item1] = value + t.Value;
                        }
                        else
                        {
                            toAdd.Add(val.Item1, t.Value);
                        }
                    }
                    else
                    {
                        string num = (long.Parse(t.Key) * 2024).ToString();
                        if (toAdd.TryGetValue(num, out long value))
                        {
                            toAdd[num] = value + t.Value;
                        }
                        else
                        {
                            toAdd.Add(num, t.Value);
                        }
                        mem.Add(t.Key, (num, ""));
                    }
                }

                if (toRemove.TryGetValue(t.Key, out long removeValue))
                {
                    toRemove[t.Key] = removeValue + t.Value;
                }
                else
                {
                    toRemove.Add(t.Key, t.Value);
                }
            }

            foreach (KeyValuePair<string, long> item in toAdd)
            {
                if (input.TryGetValue(item.Key, out long value))
                {
                    input[item.Key] = value + item.Value;
                }
                else
                {
                    input.Add(item.Key, item.Value);
                }
            }

            foreach (KeyValuePair<string, long> item in toRemove)
            {
                if (!input.TryGetValue(item.Key, out long value)) 
                    continue;
                input[item.Key] = value - item.Value;
                if (input[item.Key] <= 0)
                {
                    input.Remove(item.Key);
                }
            }
        }

        long res = 0;
        foreach (KeyValuePair<string, long> pair in input)
        {
            res += pair.Value;
        }

        return res;
    }
}