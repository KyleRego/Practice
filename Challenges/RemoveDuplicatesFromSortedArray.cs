namespace Challenges;

public class RemoveDuplicatesFromSortedArray
{
    // TODO: Practice this again
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int prevNum = nums[0];

        int writeIndex = 1;
        int readIndex = 1;

        while (readIndex < nums.Length)
        {
            int num = nums[readIndex];

            if (num == prevNum)
            {
                readIndex += 1;
            }
            else
            {
                nums[writeIndex] = num;
                prevNum = num;
                writeIndex += 1;
                readIndex += 1;
            }
        }

        return writeIndex;
    }
}