namespace Challenges;

public class MergeSortedArray
{
    // A cheap way to solve this would be to write intsB into the end of intsA
    // and then Array.Sort(intsA)

    public static void Merge(int[] intsA, int m, int[] intsB, int n)
    {
        int aIndex = 0;
        int aIntsProcessed = 0;
        int bIndex = 0;

        while (aIndex < m + n && bIndex < n)
        {
            int a = intsA[aIndex];
            int b = intsB[bIndex];

            if (aIntsProcessed == m || b <= a)
            {
                for (int j = intsA.Length - 1; j > aIndex; j -= 1)
                {
                    intsA[j] = intsA[j - 1];
                }

                intsA[aIndex] = b;
                aIndex += 1;
                bIndex += 1;
            }
            else
            {
                aIntsProcessed += 1;
                aIndex += 1;
            }
        }
    }
}