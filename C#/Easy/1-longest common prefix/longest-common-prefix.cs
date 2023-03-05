public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        string perfex = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(perfex) != 0)
            {
                perfex = perfex.Substring(0, perfex.Length - 1);
                if (perfex.Length == 0) return "";

            }
        }
        return perfex;
    }
}