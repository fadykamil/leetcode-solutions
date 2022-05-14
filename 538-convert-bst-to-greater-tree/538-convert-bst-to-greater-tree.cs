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
    private int sum = 0;
    public TreeNode ConvertBST(TreeNode root)
    {
        ConvertBSTHelper(root);
        return root;
    }

    public void ConvertBSTHelper(TreeNode root)
    {
        if (root == null) return;

        ConvertBSTHelper(root.right);
        sum = sum + root.val;
        root.val = sum ;
        
        ConvertBSTHelper(root.left);
    }
}