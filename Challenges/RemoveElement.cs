namespace Challenges;

public class RemoveElement
{
    public static int Soln(int[] nums, int val)
    {
        int insertIndex = 0;

        for (int i = 0; i < nums.Length; i += 1)
        {
            int num = nums[i];

            if (num != val)
            {
                nums[insertIndex] = num;
                insertIndex += 1;
            }
        }

        return insertIndex;
    }

    // Solve by using a swap 
    public static int Soln2(int[] nums, int val)
    {
        return 0;
    }
}