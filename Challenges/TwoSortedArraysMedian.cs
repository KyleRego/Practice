namespace Challenges;

public class TwoSortedArrays
{
    public static double FindMedian(int[] nums1, int[] nums2)
    {
        int mergedArraySize = nums1.Length + nums2.Length;
        int[] mergedArray = new int[mergedArraySize];

        int mergedArrayIndex = 0;
        int nums1Index = 0;
        int nums2Index = 0;

        while (nums1Index < nums1.Length || nums2Index < nums2.Length)
        {
            if (nums1Index == nums1.Length && nums2Index < nums2.Length)
            {
                mergedArray[mergedArrayIndex] = nums2[nums2Index];
                nums2Index += 1;
                mergedArrayIndex += 1;
            }
            else if (nums2Index == nums2.Length && nums1Index < nums1.Length)
            {
                mergedArray[mergedArrayIndex] = nums1[nums1Index];
                nums1Index += 1;
                mergedArrayIndex += 1;
            }
            else
            {
                int num1 = nums1[nums1Index];
                int num2 = nums2[nums2Index];

                if (num2 > num1)
                {
                    mergedArray[mergedArrayIndex] = num1;
                    nums1Index += 1;
                    mergedArrayIndex += 1;
                }
                else
                {
                    mergedArray[mergedArrayIndex] = num2;
                    nums2Index += 1;
                    mergedArrayIndex += 1;
                }
            }
        }

        if (mergedArraySize % 2 == 1)
        {
            return mergedArray[mergedArraySize / 2];
        }
        else
        {
            double first = mergedArray[mergedArraySize / 2 - 1];
            double second = mergedArray[mergedArraySize / 2];

            return (first + second) / 2;

        }
        
    }
}