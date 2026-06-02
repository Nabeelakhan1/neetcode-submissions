public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string,List<String>> dict=new();

        for(int i=0;i<strs.Length;i++)
        {
            string st=strs[i];
            char[] characters=st.ToCharArray();
            Array.Sort(characters);
            String str=new String(characters);

                

                if(!dict.ContainsKey(str))
                    {
                        dict[str]=new List<String>();
                    }
                    dict[str].Add(st);
            
        }
         return new List<List<string>>(dict.Values);
    }
}
