public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] result=new int[nums.Length];
        for(int i=0;i<nums.Length;i++)
        {
                int an=1;

            for(int j=0;j<nums.Length;j++)
            {
                if(i==j) continue;
                an*=nums[j];
             
            }
               result[i]=an;
        }
        return result;
    }
}
