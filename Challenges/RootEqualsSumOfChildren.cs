namespace Challenges;

public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class RootEqualsSumOfChildren
{
    public static bool Soln(TreeNode tree)
    {
        int rootVal = tree.val;

        int leftVal = tree.left?.val ?? 0;
        int rightVal = tree.right?.val ?? 0;

        return (leftVal + rightVal) == rootVal;
    }
}