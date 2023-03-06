public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> obj = new List<int>();
        TreeNode current = root;
        if (current != null)
        {
            foreach (int s in InorderTraversal(current.left))
            {
                obj.Add(s);
            }
            obj.Add(root.val);
            foreach (int s in InorderTraversal(current.right))
            {
                obj.Add(s);
            }
        }
        return obj;

    }
}