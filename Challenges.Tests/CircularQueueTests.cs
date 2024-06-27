namespace Challenges.Tests;

public class CircularQueueTests
{
    [Fact]
    public void Test1()
    {
        var queue = new MyCircularQueue(3);

        Assert.True(queue.IsEmpty());

        Assert.True(queue.Enqueue(1));

        Assert.False(queue.IsEmpty());

        Assert.True(queue.Dequeue());

        Assert.True(queue.IsEmpty());

        Assert.False(queue.Dequeue());
    }

    [Fact]
    public void Test2()
    {
        var queue = new MyCircularQueue(2);

        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.True(queue.IsFull());

        Assert.Equal(2, queue.Front());
        Assert.Equal(3, queue.Rear());
    }
}