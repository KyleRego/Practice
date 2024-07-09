namespace Challenges.Tests;

public class RemoveNthNodeFromListTests
{
    [Fact]
    public void Test1()
    {
        ListNode head = new()
        {
            val = 1,
            next = new()
            {
                val = 2
            }
        };

        ListNode? result = RemoveNthNodeFromList.Soln(head, 1);
        Assert.Equal(1, result!.val);
        Assert.Null(result.next);
    }

    [Fact]
    public void Test2()
    {
        ListNode head = new()
        {
            val = 1
        };

        Assert.Null(RemoveNthNodeFromList.Soln(head, 1));
    }

    [Fact]
    public void Test3()
    {
        ListNode head = new()
        {
            val = 1,
            next = new()
            {
                val = 2
            }
        };

        ListNode? result = RemoveNthNodeFromList.Soln(head, 2);
        Assert.Equal(2, result!.val);
        Assert.Null(result.next);
    }
}