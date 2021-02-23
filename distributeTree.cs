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
    int moves = 0;
    
    public int DistributeCoinsHelper(TreeNode root) {
        //base case
        if (root == null)
            return 0;
        
        //travers left subtree
        int left = DistributeCoinsHelper(root.left);
        
        //traverse right subtree
        int right = DistributeCoinsHelper(root.right);
        
        //update moves
        moves += Math.Abs(left) + Math.Abs(right);
        //Console.WriteLine(moves);
        
        //return number of moves to balance current node
        return root.val + left + right -1;
    }
    public int DistributeCoins(TreeNode root){
        DistributeCoinsHelper(root);
        return moves;
    }
}
