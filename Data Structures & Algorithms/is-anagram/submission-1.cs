public class Solution {
    public bool IsAnagram(string s, string t) {

            if(s.Length!=t.Length)
                return false;
            
            Dictionary<char,int>Count =new();
            for(int i=0;i<s.Length;i++)
            {
                char c=s[i];
                if(Count.ContainsKey(c))
                {
                    Count[c]++;
                }
                else{
                    Count[c]=1;
                }
            }

            //traverse now
            for(int i=0;i<s.Length;i++)
            {
                char c=t[i];
                if(!Count.ContainsKey(c))
                    return false;

                Count[c]--;
                if(Count[c]<0)
                    return false;

                
            }
            return true;
    }
}
