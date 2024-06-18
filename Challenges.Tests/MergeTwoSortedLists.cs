namespace Challenges.Tests;

public class MergeTwoSortedListsTests
{
    [Fact]
    public void Test1()
    {
        ListNode list1 = new(1, new(2, new(5, null)));
        ListNode list2 = new(3, new(4, new(6, null)));

        ListNode result = MergeTwoSortedLists.Soln(list1, list2);

        
    }
}