/*Give all possible combinations of a well formed brackets for n given pairs*/
public List<string> BracketsCombinations(int n)
{
    List<string> list = new List<string>();
    BackTrack(n, "", list, 0, 0);
    return list;
}
public void BackTrack(int n, string str, List<string> list, int open, int close)
{
    if(str.Length == n*2)
    {
        list.Add(str);
        return;
    }
    if(open < n)
    {
        BackTrack(n, str + "(", list, open + 1, close);
    }
    if(close < open)
    {
        BackTrack(n, str + ")", list, open, close + 1);
    }
}