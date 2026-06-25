public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> Set1=new();
        Dictionary<char,int> Set2=new();

if (s.Length != t.Length)
    return false;
        for(int i=0;i<s.Length;i++)
        {
            if(Set1.ContainsKey(s[i]))
            {
                Set1[s[i]]++;
            }
            else{
                Set1[s[i]]=1;
            }
        }
         for(int i=0;i<t.Length;i++)
        {
            if(Set2.ContainsKey(t[i]))
            {
                Set2[t[i]]++;
            }
            else{
                Set2[t[i]]=1;
            }
        }

        foreach(var pair in Set1)
        {
            if(!Set2.ContainsKey(pair.Key))
                return false;
            
            if(Set2[pair.Key]!=pair.Value)
                return false;
        }
        return true;
    }
}
