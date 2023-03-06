public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null)
            return false;
        ListNode current = head;
        current.val = int.MinValue;
        ListNode temp = current;
        while (temp.next != null)
        {
            temp = temp.next;
            if (temp.val == current.val)
                return true;
            temp.val = int.MinValue;
        }
        return false;
    }
}