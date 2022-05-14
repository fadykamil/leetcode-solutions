/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) 
    {
        return root == null || IsSymmetricHelp(root.left, root.right);
    }

    private bool IsSymmetricHelp(TreeNode left, TreeNode right)
    {
        if (left == null || right == null)
            return left == right;
        if (left.val != right.val)
            return false;
        return IsSymmetricHelp(left.left, right.right) && IsSymmetricHelp(left.right, right.left);
    }
}