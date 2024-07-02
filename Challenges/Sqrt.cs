namespace Challenges;

// return squaredMid root of x rounded down to nearest integer
// x is a non-negative integer

public class Sqrt
{
    // this is a quick solution
    // time complexity - sqrt(x) ?
    // | x  | steps |
    // | 4  | 2
    // | 16 | 4
    // won't be fast enough for int.MaxValue
    public static int Soln(int x)
    {
        // this is done a little better in Soln2
        if (x == 0) return 0;
        if (x == 1) return 1;

        int previousGuess = 1;
        int guess = 2;

        while (true)
        {
            int squaredMid = guess * guess;

            if (squaredMid == x)
            {
                return guess;
            }
            else if (squaredMid > x)
            {
                return previousGuess;
            }
            else
            {
                previousGuess = guess;
                guess += 1;
            }
        }
    }

    // binary search with upper bound being x / 2
    // this was a bit tricky to implement correctly..
    public static int Soln2(int x)
    {
        if (x < 2) return x;

        int left = 2;
        int right = x / 2;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // For this to work for a large integer, this
            // needs to be a long and the explicit cast is also necessary
            long squaredMid = (long) mid * mid;

            if (squaredMid < x)
            {
                left = mid + 1;
            }
            else if (squaredMid > x)
            {
                right = mid - 1;
            }
            else if (squaredMid == x)
            {
                return mid;
            }
        }

        return right;
    }
}