public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

    int[] ans=new int[nums.Length];
    int[] leftPrefix=new int[nums.Length];
    int[] rightPrefix=new int[nums.Length];

     for(int i=0;i<nums.Length;i++)
     {
      if(i==0)
      {
        leftPrefix[i]=1;
      }
      else{
        leftPrefix[i]=leftPrefix[i-1]*nums[i-1];
      }

     }
    for(int j=nums.Length-1;j>=0;j--)
    {
     
      if(j==nums.Length-1)
      {
        rightPrefix[j]=1;

      }
      else{
        rightPrefix[j]=rightPrefix[j+1]*nums[j+1];
      }
     
       
    }
    
    

    for(int i=0;i<nums.Length;i++)
    {
         ans[i]=leftPrefix[i]*rightPrefix[i];
    }
     return ans;

    
}}
