public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        ListNode Testa = headA;
        ListNode Testb = headB;
        ListNode current = headA;
        ListNode current2 = headB;
        int start = 0;

        int index = 0;
        int index2 = 0;
        while (Testa != null)
        {
            index++;
            Testa = Testa.next;
        }
        while (Testb != null)
        {
            index2++;
            Testb = Testb.next;
        }
        if (index > index2)
        {
            start = index - index2;
            for (int i = 0; i < start; i++)
                current = current.next;
        }
        else
        {
            start = index2 - index;
            for (int i = 0; i < start; i++)
                current2 = current2.next;
        }
        while (current != null && current2 != null)
        {
            if (current == current2)
                return current;
            current = current.next;
            current2 = current2.next;
        }
        return null;
    }
}