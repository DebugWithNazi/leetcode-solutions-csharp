public class Solution {
    public string Tictactoe(int[][] moves) {
        int[] rowA = new int[3], rowB = new int[3];
        int[] colA = new int[3], colB = new int[3];
        int diaA = 0, antiA = 0;
        int diaB = 0, antiB = 0;

        for(int i = 0; i< moves.Length; i++){
                var r = moves[i][0];
                var c = moves[i][1];

                if( i % 2 == 0){
                    rowA[r]++; colA[c]++;
                    if( r == c) diaA++;
                    if( r + c == 2) antiA++;
                    
                    if(rowA[r] == 3 || colA[c] ==3 || diaA == 3 || antiA == 3)
                       return "A";
                }
                else{
                    rowB[r]++; colB[c]++;
                    if(r==c) diaB++;
                    if(r+c == 2) antiB++;

                    if(rowB[r] == 3 || colB[c] ==3 || diaB == 3 || antiB == 3)
                       return "B";
                }
        }

        return moves.Length == 9 ? "Draw" : "Pending";
    }
}