public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int>Set=new();
        for(int i=0;i<nums.Length;i++)
        {
            Set.Add(nums[i]);
        }
        //
        int maxLength=0;
        foreach(int current in Set)
        {
           
           
             int length=1;
             if(Set.Contains(current-1))
             {
                continue;
             }
             int temp=current;

            while(Set.Contains(temp+1))
            {
                temp++;
                length++;
            }
            maxLength=Math.Max(maxLength,length);
        }
        return maxLength;
    }
}
