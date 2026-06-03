public class Solution {
    public bool IsPalindrome(string s) {
        
       

        string result = Regex.Replace(s, @"\s+", "");
        string cleaned = Regex.Replace(result, @"[^a-zA-Z0-9 ]", "");
        cleaned=cleaned.ToLower();
            int i=0; int j=cleaned.Length-1;
        while(i<j)
        {
            
            if(cleaned[i]!=cleaned[j])
            {
                return false;
            }
            i++;
            j--;

        }
        return true;
    }
}
