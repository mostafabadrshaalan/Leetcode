public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null || n <= 0)
        {
            return null;
        }
        if (head.next == null && n != 1)
        {
            return null;
        }
        if (head.next == null && n == 1)
        {
            return null;
        }
        var first = head;
        var second = head;
        for (int i = 0; i < n - 1; i++)
        {
            second = second.next;
        }
        while (second.next != null)
        {
            first = first.next;
            second = second.next;
        }
        var temp = head;
        if (temp == first)
        {
            return first.next;
        }
        else
        {
            while (temp.next != first)
            {
                temp = temp.next;
            }
            temp.next = first.next;
        }

        return head;

    }
}