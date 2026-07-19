public class Solution {
    public int Search(int[] nums, int target) {
     //put 2 pointers, one from left and one from right 

     int l=0;int r=nums.Length-1;
     int mid=(l+r)/2;
     while(l<=r)
     {
        mid=(l+r)/2;
        if(nums[mid]<target)
        {
            l=mid+1;
        }
        else if(nums[mid]>target)
        {
            r=mid-1;
        }
        else{
            return mid;
        }
     }   
     return -1;
    }
}
