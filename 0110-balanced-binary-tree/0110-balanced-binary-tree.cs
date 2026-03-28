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
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;

        var left = Depth(root.left);
        var right = Depth(root.right);
        var diff = Math.Abs(left - right);
        if(diff > 1) return false;
        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int Depth(TreeNode root){
        if(root == null) return 0;

        var left = Depth(root.left) + 1;
        var right = Depth(root.right) + 1;

        var depth = Math.Max(left,right);
        return depth;
    }
}