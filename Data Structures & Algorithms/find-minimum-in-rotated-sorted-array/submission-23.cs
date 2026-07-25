public class Solution {
    public int FindMin(int[] nums) {
        int l=0;int r=nums.Length-1;
        int mid=(l+r)/2;
        while(l<=r)
        {
            mid=(l+r)/2;

            if(nums[mid]<nums[r])
            {
                r=mid;
            }
            else if(nums[mid]>=nums[r])
            {
                l=mid+1;
            }
            else{
                return nums[mid];
            }
          
           
        }
        return nums[mid] ;

    }
}
