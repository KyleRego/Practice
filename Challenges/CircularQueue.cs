namespace Challenges;

public class MyCircularQueue(int k)
{
    private readonly int[] elements = new int[k];
    private int headIndex = 0;
    private int tailIndex = 0;

    private int amtInside = 0;

    public bool Enqueue(int val)
    {
        if (amtInside < k)
        {
            elements[tailIndex] = val;

            if (tailIndex == elements.Length - 1)
            {
                tailIndex = 0;
            }
            else
            {
                tailIndex += 1;
            }

            amtInside += 1;

            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Dequeue()
    {
        if (amtInside > 0)
        {
            if (headIndex == elements.Length - 1)
            {
                headIndex = 0;
            }
            else
            {
                headIndex += 1;
            }

            amtInside -= 1;

            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsEmpty()
    {
        return amtInside == 0;
    }

    public bool IsFull()
    {
        return amtInside == k;
    }

    public int Front()
    {
        if (amtInside > 0)
        {
            return elements[headIndex];
        }
        else
        {
            return -1;
        }
    }

    public int Rear()
    {
        if (amtInside > 0)
        {
            if (tailIndex == 0)
            {
                return elements[k - 1];
            }
            else
            {
                return elements[tailIndex - 1];
            }
        }
        else
        {
            return -1;
        }
    }
}