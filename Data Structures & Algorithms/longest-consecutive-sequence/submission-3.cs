public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int>Set=new();
        for(int i=0;i<nums.Length;i++)
        {
            Set.Add(nums[i]);
        }
        //
        int maxLength=0;
        for(int i=0;i<nums.Length;i++)
        {
           
            int current=nums[i];
             int length=1;
            while(Set.Contains(current+1))
            {
                current++;
                length++;
            }
            maxLength=Math.Max(maxLength,length);
        }
        return maxLength;
    }
}
