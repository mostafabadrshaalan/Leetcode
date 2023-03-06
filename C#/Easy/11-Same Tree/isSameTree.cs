public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        if (p != null && q != null)
        {
            return p.val == q.val
            && IsSameTree(p.right, q.right)
            && IsSameTree(p.left, q.left);

        }
        return false;
    }
}