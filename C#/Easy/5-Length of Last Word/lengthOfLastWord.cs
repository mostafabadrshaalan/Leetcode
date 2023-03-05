public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        string[] words = s.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (i == words.Length - 1)
            {
                return words[i].Count();
            }
        }
        return 0;
    }
}