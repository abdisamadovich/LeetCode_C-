public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> symbols = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int current = symbols[s[i]];
            int next = (i + 1 < s.Length) ? symbols[s[i + 1]] : 0;
            if (current < next)
            {
                result -= current;
            }
            else
            {
                result += current;
            }
        }
        return result;
    }
}
class Program
{
    static void Main()
    {
        string s = "XXX";
        Solution solution = new Solution();
        int natija = solution.RomanToInt(s);
        Console.WriteLine(natija);
    }
}

