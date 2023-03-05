public class Solution
{
    Stack st;
    public bool IsValid(string s)
    {
        st = new Stack(s.Length);
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '<' || s[i] == '{' || s[i] == '[')
            {
                st.Push(s[i]);
            }
            else
            {
                if (IsEmpty() || !ispair((char)st.Peek(), s[i]))
                {
                    return false;
                }
                else
                {
                    st.Pop();
                }
            }
        }
        return IsEmpty();
    }

    public bool IsEmpty()
    {
        return st.Count == 0;
    }
    public bool ispair(char c1, char c2)
    {
        if (c1 == '(' && c2 == ')' || c1 == '{' && c2 == '}' || c1 == '[' && c2 == ']')
            return true;
        else
            return false;
    }


}
