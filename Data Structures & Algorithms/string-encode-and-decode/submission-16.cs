public class Solution {

    public string Encode(IList<string> strs) {
        
        string encoded="";
        for(int i=0;i<strs.Count;i++)
        {
            encoded+=strs[i].Length+"#"+strs[i];
        }
        return encoded;
    }

    public List<string> Decode(string s) {

        List<string> result=new();
        int i=0;
        while(i<s.Length)
        {
            int index=s.IndexOf('#',i);

            int length=index-i;
            string re=s.Substring(i,length);
            int count=int.Parse(re);

        i=index+1;
            string str="";
            for(int j=0;j<count;j++)
            {
                str+=s[i];
                i++;
            }
        result.Add(str);
        }
        return result;
   }
}
