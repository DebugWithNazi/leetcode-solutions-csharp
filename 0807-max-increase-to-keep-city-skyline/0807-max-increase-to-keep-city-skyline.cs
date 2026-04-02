public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        int n = grid.Length; 
        var maxRow = new int[n]; // s = O(n)
        var maxCol = new int[n]; // s = O(n)

        for(int i=0; i< n; i++){               // t= O(n^2) 
            for(int j = 0; j<n; j++){
                maxRow[i] = Math.Max(maxRow[i], grid[i][j]);
                maxCol[j] = Math.Max(maxCol[j], grid[i][j]);
            }
        }

        int total = 0;

        for(int i=0; i< n; i++){  //t = O(n^2)
            for(int j = 0; j<n; j++){
                total += Math.Min(maxRow[i],maxCol[j]) - grid[i][j];
            }
        }
        return total;
    }
}

// t= O(n^2)+ O(n^2)  = O(n^2) 
// s = O(n) + O(n) = O(n)