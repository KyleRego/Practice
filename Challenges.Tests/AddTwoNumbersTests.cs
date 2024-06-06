namespace Challenges.Tests;

public class AddTwoNumbersTests
{
    [Fact]
    public void Test1()
    {
        // 947
        ListNode one = new()
        {
            val = 7,
            next = new()
            {
                val = 4,
                next = new()
                {
                    val = 9,
                    next = null
                }
            }
        };

        // 23
        ListNode two = new()
        {
            val = 3,
            next = new()
            {
                val = 2,
                next = null
            }
        };

        ListNode expected = new()
        {
            val = 0,
            next = new()
            {
                val = 7,
                next = new()
                {
                    val = 9,
                    next = null
                }
            }
        };

        ListNode result = AddTwoNumbers.AddTwoNumbersSol(one, two);

        Assert.Equal(0, result.val);
        Assert.Equal(7, result.next?.val);
        Assert.Equal(9, result.next?.next?.val);
    }
}