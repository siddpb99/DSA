
public class Solution
{
    public string IntToRoman(int num)
    {
        StringBuilder str = new StringBuilder("");

        Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}
            };

        foreach (var item in dict)
        {
            while (num >= item.Key)
            {
                str.Append(item.Value);
                num -= item.Key;
            }
        }
        return str.ToString();
    }
}