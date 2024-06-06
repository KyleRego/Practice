namespace Challenges;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class AddTwoNumbers
{
    public static ListNode AddTwoNumbersSol(ListNode l1, ListNode l2)
    {
        ListNode? soln = null;
        ListNode? lastSolnNode = null;

        ListNode? currentL1Node = l1;
        ListNode? currentL2Node = l2;

        int carry = 0;

        while (currentL1Node != null || currentL2Node != null || carry != 0)
        {
            int val1 = currentL1Node?.val ?? 0;
            int val2 = currentL2Node?.val ?? 0;

            int sum = val1 + val2 + carry;

            int digit = sum % 10;
            carry = sum / 10;

            ListNode nextSolnNode = new()
            {
                val = digit
            };

            if (soln == null)
            {
                soln = nextSolnNode;
                lastSolnNode = nextSolnNode;
            }
            else
            {
                ArgumentNullException.ThrowIfNull(lastSolnNode);
                lastSolnNode.next = nextSolnNode;
                lastSolnNode = nextSolnNode;
            }

            currentL1Node = currentL1Node?.next ?? null;
            currentL2Node = currentL2Node?.next ?? null;
        }

        ArgumentNullException.ThrowIfNull(soln);
        return soln;
    }
}
