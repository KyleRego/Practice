namespace Challenges;

public class SortAnArray
{
    // this solution exceeds time limit
    // I'm curious if this is a variation of a named sorting algorithm,
    // I think it probably is
    public static int[] SortArray(int[] nums)
    {
        bool sorted = false;

        while (sorted == false)
        {
            sorted = true;

            for (int i = 0; i < nums.Length - 1; i += 1)
            {
                int first = nums[i];
                int second = nums[i + 1];

                if (first > second)
                {
                    nums[i] = second;
                    nums[i + 1] = first;
                    sorted = false;
                }
            }
        }

        return nums;
    }

    // merge sort

    public static int[] MergeSort(int[] nums)
    {
        if (nums.Length <= 1) return nums;

        int pivot = nums.Length / 2 ;

        int[] nums1 = nums[0 .. pivot];
        int[] nums2 = nums[pivot .. ^0];

        int[] sortedNums1 = MergeSort(nums1);
        int[] sortedNums2 = MergeSort(nums2);

        int insertIndex = 0;
        int[] result = new int[nums.Length];

        int index1 = 0;
        int index2 = 0;

        while (index1 < sortedNums1.Length || index2 < sortedNums2.Length)
        {
            if (index1 == sortedNums1.Length)
            {
                result[insertIndex] = sortedNums2[index2];
                index2 += 1;
                insertIndex += 1;
            }
            else if (index2 == sortedNums2.Length)
            {
                result[insertIndex] = sortedNums1[index1];
                index1 += 1;
                insertIndex += 1;
            }
            else
            {
                int num1 = sortedNums1[index1];
                int num2 = sortedNums2[index2];

                if (num2 > num1)
                {
                    result[insertIndex] = num1;
                    index1 += 1;
                }
                else
                {
                    result[insertIndex] = num2;
                    index2 += 1;
                }
                insertIndex += 1;
            }
        }

        return result;
    }

    // TODO: heap sort

    // counting sort
    // this solution has very good time and space complexity on submission
    public static int[] CountingSort(int[] nums)
    {
        Dictionary<int, int> counts = [];

        int minVal = int.MaxValue;
        int maxVal = int.MinValue;

        for (int i = 0; i < nums.Length; i += 1)
        {
            int num = nums[i];

            minVal = Math.Min(num, minVal);
            maxVal = Math.Max(num, maxVal);

            if (counts.TryGetValue(num, out int _))
            {
                counts[num] += 1;
            }
            else
            {
                counts[num] = 1;
            }
        }

        int insertIndex = 0;
        int[] result = new int[nums.Length];

        for (int i = minVal; i <= maxVal; i += 1)
        {
            if (counts.TryGetValue(i, out int _))
            {
                while (counts[i] > 0)
                {
                    result[insertIndex] = i;
                    counts[i] -= 1;
                    insertIndex += 1;
                }
            }
        }

        return result;
    }
}