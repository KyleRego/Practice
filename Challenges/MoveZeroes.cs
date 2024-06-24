namespace Challenges;

public class MoveZeroes
{
    // TODO: Not a bad one to practice again,
    // Try to do with a 2 index approach
    public static void Soln(int[] nums)
    {
        int insertIndex = 0;

        for (int i = 0; i < nums.Length; i += 1)
        {
            int num = nums[i];

            if (num != 0)
            {
                nums[insertIndex] = num;
                insertIndex += 1;
            }
        }

        for (int j = insertIndex ; j < nums.Length; j += 1)
        {
            nums[j] = 0;
        }
    }
}