public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int[] ans=new int[nums.Length];
     for(int i=0;i<nums.Length;i++)
     {
        int currentIndex=i;
          int prod=1;
        for(int j=0;j<nums.Length;j++)
        {
           
            if(j==currentIndex)
            {
                continue;
            }
          
            prod*=nums[j];
        }
    ans[i]=prod;

     }   
     return ans;

    }
}
