public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null)
            return null;

        if (head.next == null)
            return head;

        ListNode current = head;
        ListNode Next = current.next;
        ListNode temp = new ListNode(0);
        while (current != null)
        {
            temp.val = current.val;
            current.val = Next.val;
            Next.val = temp.val;
            Next = Next.next;
            if (Next == null)
            {
                Next = current.next;
                current = current.next;
            }
        }
        return head;
    }
}