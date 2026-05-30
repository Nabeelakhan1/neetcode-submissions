public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int>map=new();
        for(int i=0;i<nums.Length;i++)
        {
            int compliment=target-nums[i];
            if(map.ContainsKey(compliment))
            {
                return new int[] {map[compliment],i};
            }
            if(!map.ContainsKey(compliment))
            {
                map[nums[i]]=i;
            }


        }
        return new int[] {-1,-1};
      
    }
}
