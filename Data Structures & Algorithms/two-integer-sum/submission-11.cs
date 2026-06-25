public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map=new();

        for(int i=0;i<nums.Length;i++)
        {
            map[nums[i]]=i;
        }
        for(int j=0;j<nums.Length;j++)
        {
            int comp=target-nums[j];
            if(map.ContainsKey(comp))
            {
                if(map[comp]==j) continue;
               int[] ans = new int[] { j, map[comp] };
                return ans;
            }
        }
             int[] an = new int[] { -1, -1};  
             return an;
    }

}
