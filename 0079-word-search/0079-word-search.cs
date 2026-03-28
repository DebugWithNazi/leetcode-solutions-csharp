public class Solution {
    public bool Exist(char[][] board, string word) {
        
        for(int i =0; i< board.Length; i++){
            for(int j = 0; j < board[0].Length; j++){
                if(DFS(board,i,j,word,0)){
                    return true;
                }
            }
        }
        return false;
    }

    bool DFS(char[][] board, int i, int j, string word, int index){

        if(index == word.Length) return true;

        if(i < 0 || i >= board.Length) return false;
        if(j < 0 || j >= board[0].Length) return false;

        if(board[i][j] != word[index]) return false;

        var temp = board[i][j];
        board[i][j] = '#';

        var found = DFS(board, i+1 , j, word, index + 1) || 
                    DFS(board, i-1 , j, word, index + 1) || 
                    DFS(board, i , j+1, word, index + 1) || 
                    DFS(board, i , j-1, word, index + 1);

        board[i][j] = temp;
        return found;        
    }
}