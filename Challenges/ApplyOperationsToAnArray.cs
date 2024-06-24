namespace Challenges;

public class ApplyOperationsToAnArray
{
    public static int[] ApplyOperations(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i += 1)
        {
            int num = nums[i];
            int nextNum = nums[i + 1];

            if (num == nextNum)
            {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
        }

        int insertIndex = 0;
        int zerosCounter = 0;

        for (int i = 0; i < nums.Length; i += 1)
        {
            int num = nums[i];

            if (num != 0)
            {
                nums[insertIndex] = num;
                insertIndex += 1;
            }
            else if (num == 0)
            {
                zerosCounter += 1;
            }
        }

        for (int j = 0; j < zerosCounter; j += 1)
        {
            nums[nums.Length - 1 - j] = 0;
        }

        return nums;
    }
}