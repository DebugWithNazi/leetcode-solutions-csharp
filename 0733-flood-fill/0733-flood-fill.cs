public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        var target = image[sr][sc];

        if(target == color) return image;

        DFS(image, sr, sc, target, color);
        return image;
    }

    public void DFS(int[][] image, int r, int c, int target, int color){
        
        if(r < 0 || r >= image.Length) return;
        if(c < 0 || c >= image[0].Length) return;
        if(image[r][c] != target) return;

        image[r][c] = color;

        DFS(image, r-1, c, target, color);
        DFS(image, r+1, c, target, color);
        DFS(image, r, c-1, target, color);
        DFS(image, r, c+1, target, color);
    }
}