namespace Challenges;

public class SymmetricTree
{
    // this solution works; but there is a really much more
    // elegant way to do it with recursion

    // this approach is not in the leetcode editorial
    public static bool IsSymmetric(TreeNode root)
    {
        // depth, horizontal
        Dictionary<(int, string), int> tracker = [];

        ComputeTracker(root, tracker, 0, "");

        foreach ((int, string) coord in tracker.Keys)
        {
            if (coord.Item1 == 0) continue;

            int depth = coord.Item1;
            string horizontal = coord.Item2;

            string complement = "";

            foreach(char lOrR in horizontal)
            {
                if (lOrR == 'r')
                {
                    complement += "l";
                }
                else
                {
                    complement += "r";
                }
            }

            if (tracker.TryGetValue((depth, complement), out int val))
            {
                if (tracker[coord] == val)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    private static void ComputeTracker(TreeNode node, Dictionary<(int, string), int> tracker, int depth, string horizontal)
    {
        tracker[(depth, horizontal)] = node.val;

        if (node.left != null)
        {
            string leftHorizontal = new(horizontal);
            leftHorizontal += "l";

            ComputeTracker(node.left, tracker, depth + 1, leftHorizontal);
        }

        if (node.right != null)
        {
            string rightHorizontal = new(horizontal);
            rightHorizontal += "r";

            ComputeTracker(node.right, tracker, depth + 1, rightHorizontal);
        }
    }
}