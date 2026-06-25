public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> Map=new();
        for(int i=0;i<nums.Length;i++)
        {
            if(Map.ContainsKey(nums[i]))
            {
                return true;
            }
            if(!Map.ContainsKey(nums[i]))
            {
                Map[nums[i]]=nums[i];
            }
               
            
        }
        return false;
        
    }
}