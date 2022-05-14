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
    public bool IsValidBST(TreeNode root) 
     {
        var traverse = InorderTraversal(root);

        for (int i = 0; i < traverse.Count; i++)
        {
            if (i < traverse.Count - 1 && traverse[i] >= traverse[i + 1])
                return false;
        }
        
        return true;
    }


    private IList<int> result = new List<int>();

    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root != null)
        {
            InorderTraversal(root.left);
            result.Add(root.val);
            InorderTraversal(root.right);
        }

        return result;
    }
}