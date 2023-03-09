public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null)
            return null;

        if (head.val == val)
        {
            while (head.val == val)
            {
                head = head.next;
                if (head == null)
                    return null;
            }
        }

        if (head.next == null)
            return head;

        ListNode current = head.next;
        ListNode temp = head;

        while (current != null)
        {
            if (current.val == val)
            {
                temp.next = current.next;
                temp = head;
                current = head.next;
            }
            else
            {
                temp = current;
                current = current.next;
            }
        }
        Console.WriteLine(temp.val);
        return head;
    }
}