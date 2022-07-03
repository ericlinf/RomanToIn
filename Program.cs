using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(String[] args)
    {
        Console.WriteLine(RomanToInt("MCMXCIV"));
    }

    public static int RomanToInt(string s)
    {
        IDictionary<string, int> values = new Dictionary<string, int>
        {
            { "I", 1 },
            { "IV", 4 },
            { "V", 5 },
            { "IX", 9 },
            { "X", 10 },
            { "XL", 40 },
            { "L", 50 },
            { "XC", 90 },
            { "C", 100 },
            { "CD", 400 },
            { "D", 500 },
            { "CM", 900 },
            { "M", 1000 }
        };

        char[] chars = s.ToCharArray();
        StringBuilder sb = new();
        
        string str;
        int sum = 0;
        int num;
        for(int i = chars.Length - 1; i >= 0; i--)
        {
            sb.Clear();
            if (i > 0)
            {
                sb.Append(Char.ToUpper(chars[i - 1]));
                sb.Append(Char.ToUpper(chars[i]));
                str = sb.ToString();

                if(values.TryGetValue(str, out num))
                {
                    i--;
                    sum += num;
                    continue;
                }

            }

            values.TryGetValue(Char.ToUpper(chars[i]).ToString(), out num);

            sum += num;

        }

        return sum;
    }
}