namespace Challenges;

public class MiddleIndexInArray
{
    public static int FindMiddleIndex(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 0;
        }

        for (int i = 0; i < nums.Length; i += 1)
        {
            int leftSum = 0;

            for (int j = 0; j < i; j += 1)
            {
                leftSum += nums[j];
            }

            int rightSum = 0;

            for (int j = nums.Length - 1; j > i; j -= 1)
            {
                rightSum += nums[j];
            }

            if (leftSum == rightSum)
            {
                return i;
            }
        }

        return -1;
    }
}