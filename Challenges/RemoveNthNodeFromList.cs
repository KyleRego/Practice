namespace Challenges;

public class RemoveNthNodeFromList
{
    // this can be solved in a different way;
    // this is the two pass approach, it
    // can be done in 1 pass by tracking 2 nodes
    // instead of 1
    public static ListNode? Soln(ListNode? head, int n)
    {
        if (head == null) return null;

        int length = 1;
        ListNode? currentNode = head;

        while (currentNode.next != null)
        {
            length += 1;
            currentNode = currentNode.next;
        }

        if (length == 1)
        {
            return null;
        }

        int positionToRemove = length + 1 - n;

        int position = 1;
        ListNode? lastNode = null;
        currentNode = head;

        while (position != positionToRemove)
        {
            position += 1;
            lastNode = currentNode;
            currentNode = currentNode.next!;
        }

        ListNode? followingNode = currentNode.next;
        if (lastNode != null)
        {
            lastNode.next = followingNode;
        }
        else
        {
            head = followingNode;
        }

        return head;
    }
}