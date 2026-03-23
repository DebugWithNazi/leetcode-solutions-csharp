public class Solution
{
    public int[] DiStringMatch(string s)
    {
        var arr = new List<int>();
        var high = s.Length;
        var low = 0;
        for (int i = 0; i < s.Length ; i++)
        {
            if (s[i] == 'I')
            {
                arr.Add(low);
                low++;
            }
            else
            {
                arr.Add(high);
                high--;
            }
        }
        if(high > 0)
        {
            arr.Add(high);
        }
        else
        {
            arr.Add(low);
        }
        return arr.ToArray();
    }
}