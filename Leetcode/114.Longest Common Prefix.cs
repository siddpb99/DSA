public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        string word = strs[0];
        int max = word.Length;

        for (int i = 1; i < strs.Length; i++)
        {
            int j = 0;
            string wordn = strs[i];
            while (j < max && j < wordn.Length && word[j] == wordn[j]) // yha pe j< max ke wjh se itearation km hote jayega 
            {
                j++;
            }
            max = j;
            if (max == 0)
                return "";
        }

        return word.Substring(0, max);
    }
}