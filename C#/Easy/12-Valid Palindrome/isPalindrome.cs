public class Solution
{
    public bool IsPalindrome(string s)
    {
        s = s.Replace(" ", "").ToLower();
        if (s == "")
            return true;
        string test = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
                test += s[i];
        }
        if (test.Length == 1)
            return true;
        for (int i = 0, j = test.Length - 1; i < test.Length && j >= 0; j--, i++)
        {
            if (test[i] != test[j])
                return false;
        }
        return true;
    }
}