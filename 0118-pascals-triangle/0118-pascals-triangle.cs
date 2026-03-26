public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var arr = new List<IList<int>>();

        var row0 = new List<int>(){1};
        arr.Add(row0);

        if(numRows > 1)
        {
        var row1 = new List<int>(){ 1, 1 };
        arr.Add(row1);
        }

        for(int i = 2; i<numRows; i++){
            var row = new List<int>();
            row.Add(1);
            for(int j = 0; j<arr[i-1].Count-1; j++){

                row.Add(arr[i-1][j] + arr[i-1][j+1]);

            }
            row.Add(1);
            arr.Add(row);
        }
        return arr;
    }
}