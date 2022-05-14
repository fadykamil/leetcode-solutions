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
    TreeNode cur;
    public TreeNode IncreasingBST(TreeNode root) {
        TreeNode ans = new TreeNode(0);
        cur = ans;
        Inorder(root);
        return ans.right;
    }

    public void Inorder(TreeNode node) {
        if (node == null) return;
        Inorder(node.left);
        node.left = null;
        cur.right = node;
        cur = node;
        Inorder(node.right);
    }
}