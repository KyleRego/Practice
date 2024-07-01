namespace Challenges;

// no unit test file for this one
public class RemoveDuplicatesFromSortedList
{
    // On leetcode, you do need a guard clause for if head == null
    // (but the parameter is not nullable)
    // The editorial says this is a simple test if you can
    // manipulate "list node pointers"
    public static ListNode DeleteDuplicates(ListNode head)
    {
        ListNode currNode = head;
        ListNode? nextNode = currNode.next;

        while (nextNode != null)
        {
            int val = nextNode.val;

            if (val == currNode.val)
            {
                nextNode = nextNode.next;
                currNode.next = nextNode;
            }
            else
            {
                ListNode? temp = nextNode.next;
                currNode = nextNode;
                nextNode = temp;
            }
        }

        return head;    
    }
}