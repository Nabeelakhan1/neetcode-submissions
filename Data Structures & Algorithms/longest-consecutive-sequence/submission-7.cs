public class Solution {
    public int LongestConsecutive(int[] nums) {

        HashSet<int> set=new();

        
       for (int i=0;i<nums.Length;i++)
       {
        set.Add(nums[i]);
       }
      int maxlength=0;
       foreach(int current in set)
       {
            if(set.Contains(current-1))
            {
                continue;
            }
            int length=1;
            int temp=current;
            while(set.Contains(temp+1))
            {
                length++;
                temp++;
            }
        maxlength=Math.Max(length,maxlength);
       }

    return maxlength;
    }
}
