public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        List<List<String>> result=new();
        HashSet<int> seen=new();

        for(int i=0;i<strs.Length;i++)
        {
            if(seen.Contains(i)) continue;

            Char[] tar=strs[i].ToCharArray();
            Array.Sort(tar);
            string target=new string(tar);

            List<string> res=new();
            res.Add(strs[i]);

            for(int j=i+1;j<strs.Length;j++)
            {
                Char[] t=strs[j].ToCharArray();
                Array.Sort(t);
                string tt=new string(t);

                
                if(target.Length!=tt.Length) continue;

               if(tt==target)
               {
                     res.Add(strs[j]);
                    seen.Add(j);
               }
               
            }
            result.Add(res);
        }
        return result;
    }

}
