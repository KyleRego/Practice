namespace Challenges;

// leetcode 1823

public class CircularGameWinner
{
    // this is a straightforward impl of the problem description
    // good problem to practice checking not accessing past
    // the end of the array
    public static int FindTheWinner(int n, int k)
    {
        List<int> candidates = [];

        for (int i = 1; i <= n; i += 1)
        {
            candidates.Add(i);
        }

        int pos = 0;

        while (candidates.Count > 1)
        {
            for (int j = 1; j < k; j += 1)
            {
                pos += 1;

                if (pos == candidates.Count)
                {
                    pos = 0;
                }
            }

            candidates.RemoveAt(pos);

            if (pos == candidates.Count)
            {
                pos = 0;
            }
        }

        return candidates.First();    
    }

    // this is an interesting way to do it with a queue
    public static int QueueSoln(int n, int k)
    {
        Queue<int> queue = [];

        for (int i = 1; i <= n; i += 1)
        {
            queue.Enqueue(i);
        }

        while (queue.Count > 1)
        {
            for (int i = 0; i < k - 1; i += 1)
            {
                queue.Enqueue(queue.Dequeue());
            }

            queue.Dequeue();
        }

        return queue.Dequeue();
    }
}