public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 1) return 1;
        int[] p = new int[n + 1];
        p[1] = 1;
        p[2] = 2;
        for (int i = 3; i <= n; i++)
        {
            p[i] = p[i - 1] + p[i - 2];
        }

        return p[n];
    }
}