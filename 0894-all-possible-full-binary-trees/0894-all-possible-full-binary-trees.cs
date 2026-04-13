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
    private Dictionary<int, List<TreeNode>> memo = new();

    private TreeNode Clone(TreeNode node) {
        if (node == null) return null;
        return new TreeNode(0, Clone(node.left), Clone(node.right));
    }

    public IList<TreeNode> AllPossibleFBT(int n) {
        
        if(n == 1) return new List<TreeNode> { new TreeNode(0) };

        if(n % 2 == 0) return new List<TreeNode>();

        if(memo.ContainsKey(n)) return memo[n];

        var result = new List<TreeNode>();

        for(int left = 1; left < n; left += 2){
            var right = n-1-left;

            foreach(var leftTree in AllPossibleFBT(left)){
                foreach(var rightTree in AllPossibleFBT(right))
                {
                    var root = new TreeNode(0);
                    root.left = Clone(leftTree);
                    root.right = Clone(rightTree);
                    result.Add(root);
                }
            }

        }
            memo[n] = result;
            return result; 
    }
}