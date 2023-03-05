public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;
        if (head.next == null) return head;
        ListNode current = head;
        ListNode temp = head.next;
        while (temp != null)
        {
            if (current.val == temp.val)
            {
                current.next = temp.next;
                temp = head.next;
                current = head;
            }
            else
            {
                current = current.next;
                temp = temp.next;
            }

        }
        return head;
    }
}