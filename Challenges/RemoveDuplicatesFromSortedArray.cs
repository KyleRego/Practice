namespace Challenges;

public class RemoveDuplicatesFromSortedArray
{
    // Practice this again
    public static int RemoveDuplicates(int[] nums)
    {
        int insertIndex = 1;

        for (int i = 1; i < nums.Length; i += 1)
        {
            int num = nums[i];

            if (nums[i - 1] != num)
            {
                nums[insertIndex] = num;
                insertIndex += 1;
            }
        }

        return insertIndex;
    }
}