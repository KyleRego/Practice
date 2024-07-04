namespace Challenges;

public class GrayCode
{
    // This can be solved with backtracking
    // Need to implement helper method to get the possible next ints
    // from flipping a bit though, which I'm not sure about
    // Have a look at this later on after some other problems that involve bits

    public static int[] Soln(int n)
    {
        int length = n ^ 2;

        int[] result = new int[length];

        // BackTrack; keep track of used ints. add ints in, when length is reached
        // check if a valid solution, if it is; set result and return

        return result;
    }

    // private int[] FlipOneBitCandidates(int howManyBits, int previousNum)
    // {
    //     
    // }

    // private static void BackTrack(int[] result, List<int> possibleSoln, List<int> used, int length)
    // {
    //     if (possibleSoln.Count == length)
    //     {
            
    //     }
    // }
}