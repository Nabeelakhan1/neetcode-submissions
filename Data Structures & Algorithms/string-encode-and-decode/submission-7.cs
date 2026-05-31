public class Solution {

    public string Encode(IList<string> strs) 
    {
        string result="";
        for(int i=0;i<strs.Count;i++)
        {
            result+=strs[i].Length+":"+strs[i];
        }
        return result;
    }

    public List<string> Decode(string s)
    {
        List<string> decode=new();

        int i=0;
        while(i<s.Length)
        {

        
       int colonIndex=s.IndexOf(':',i);
       string strLength=s.Substring(i,colonIndex-i);
       int len=int.Parse(strLength);

        int start=colonIndex+1;
       string word=s.Substring(start,len);
       decode.Add(word);
       i=start+len;}
       return decode;

   }
}
