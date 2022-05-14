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
    int? prev = null;
    int count = 1;
    int max = 0;

    public int[] FindMode(TreeNode root)
    {
        if (root == null) return Array.Empty<int>();

        List<int> list = new();
        Traverse(root, list);

        var res = new int[list.Count];
        for (var i = 0; i < list.Count; ++i)
            res[i] = list[i];
        return res;
    }

    private void Traverse(TreeNode root, List<int> list)
    {
        if (root == null) return;
        Traverse(root.left, list);
        if (prev != null)
        {
            if (root.val == prev)
                count++;
            else
                count = 1;
        }

        if (count > max)
        {
            max = count;
            list.Clear();
            list.Add(root.val);
        }
        else if (count == max)
            list.Add(root.val);

        prev = root.val;
        Traverse(root.right, list);
    }
}