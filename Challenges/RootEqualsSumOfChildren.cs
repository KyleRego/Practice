namespace Challenges;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
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