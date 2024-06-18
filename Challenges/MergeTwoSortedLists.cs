namespace Challenges;

// This problem has a good solution that uses recursion
public class MergeTwoSortedLists
{
    public static ListNode Soln(ListNode list1, ListNode list2)
    {
        ListNode? soln;
        ListNode? tail;
        ListNode? a = list1;
        ListNode? b = list2;
        
        if (a.val > b.val)
        {
            soln = b;
            tail = b;
            b = b.next;
        }
        else
        {
            soln = a;
            tail = a;
            a = a.next;
        }

        while (a != null || b != null)
        {
            if (a == null)
            {
                tail.next = b;
                return soln;
            }
            else if (b == null)
            {
                tail.next = a;
                return soln;
            }
            else
            {
                int aVal = a.val;
                int bVal = b.val;

                if (aVal > bVal)
                {
                    tail.next = b;
                    tail = b;
                    b = b.next;
                }
                else
                {
                    tail.next = a;
                    tail = a;
                    a = a.next;
                }
            }
        }

        return soln;
    }
}