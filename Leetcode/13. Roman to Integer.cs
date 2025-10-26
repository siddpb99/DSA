public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;
        Dictionary<string, int> dict = new Dictionary<string, int>(){
            {"M",1000},
            {"CM",900},
            {"D",500},
            {"CD",400},
            {"C",100},
            {"XC",90},
            {"L",50},
            {"XL",40},
            {"X",10},
            {"IX",9},
            {"V",5},
            {"IV",4},
            {"I",1}
        };

        for (int i = 0; i < s.Length;)// foreach nhi use kr skte hai kyuki ek se jyada characters check krne hai
        {
            // Check for two-character match first
            if (i + 1 < s.Length && dict.ContainsKey(s.Substring(i, 2)))
            {
                result += dict[s.Substring(i, 2)];// yna pe substring use krenge kyuki 1 se jyada characters check krna hai
                i += 2;
            }
            else
            {
                result += dict[s[i].ToString()];
                i++;
            }
        }

        return result;
    }
}