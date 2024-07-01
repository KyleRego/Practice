namespace Challenges;

public class MaximumDepthOfBinaryTree
{
    public static int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        TreeNode? left = root.left;
        TreeNode? right = root.right;

        if (left != null && right != null)
        {
            return 1 + Math.Max(MaxDepth(left), MaxDepth(right));
        }
        else if (left != null)
        {
            return 1 + MaxDepth(left);
        }
        else if (right != null)
        {
            return 1 + MaxDepth(right);
        }
        else
        {
            return 1;
        }
    }
}