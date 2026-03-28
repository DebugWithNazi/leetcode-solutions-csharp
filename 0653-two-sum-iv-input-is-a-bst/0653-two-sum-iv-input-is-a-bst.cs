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
    public bool FindTarget(TreeNode root, int k) {
        var list = new List<int>();

        void SortedList(TreeNode root){
            if(root == null) return;

            SortedList(root.left);
            list.Add(root.val);
            SortedList(root.right);
        }
        SortedList(root);
        var left = 0; 
        var right = list.Count - 1;

        while(left < right){
            var sum = list[left] + list[right];
            if(sum == k){
                return true;
            }
            else if(sum < k){
                left++;
            }
            else if(sum > k){
                right--;
            }
        }
        return false;
    }
}