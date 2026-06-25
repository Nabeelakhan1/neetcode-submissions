public class Solution {
    public bool IsAnagram(string s, string t) {
  
       Char[] Schars=s.ToCharArray();
       Array.Sort(Schars);
       string Sstring=new string(Schars);
        
        Char[] Tchars=t.ToCharArray();
       Array.Sort(Tchars);
       string Tstring=new string(Tchars);

       if(s.Length!=t.Length)
       {
        return false;
       }

       for(int i=0;i<t.Length;i++)
       {
        if(Sstring[i]!=Tstring[i])
        {
            return false;
        }

       }
       return true;
    }
}
