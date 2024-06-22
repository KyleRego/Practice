namespace Challenges;

// no tests for this one but submitted on leetcode
public class LinkedListCycle
{
    // This passes tests but the runtime and memory use is bad
    public static bool HasCycle(ListNode head)
    {
        if (head == null) return false;

        List<ListNode> seenNodes = [head];

        ListNode? next = head.next;

        while (next != null)
        {
            if (seenNodes.Contains(next))
            {
                return true;
            }
            else
            {
                seenNodes.Add(next);
            }

            next = next.next;
        }

        return false;
    }

    // use a HashSet instead
    // this does much better for runtime
    public static bool HasCycle2(ListNode head)
    {
        if (head == null) return false;

        HashSet<ListNode> nodes = [head];

        ListNode? next = head.next;

        while (next != null)
        {
            if (nodes.Contains(next))
            {
                return true;
            }
            else
            {
                nodes.Add(next);
                next = next.next;
            }
        }

        return false;
    }
}