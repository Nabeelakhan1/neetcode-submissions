public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<int> res=new();
        List<List<int>> result=new();

        for(int i=0;i<nums.Length;i++)
        {
            if(i!=0)
            {
                  if(nums[i]==nums[i-1] && i>0 ) continue;
            }
          

            int j=i+1;
            int k=nums.Length-1;
            int target=-nums[i];

            while(j<k)
            {
             

                if(nums[j]+nums[k]>target)
                {
                    
                        k--;
                    
                }
                else if(nums[j]+nums[k]<target)
                {
                    
                        j++;
                    
                    
                }
                else{
                    res=new();

                    res.Add(nums[i]);
                    res.Add(nums[j]);
                    res.Add(nums[k]);

                    j++;
                    k--;
                    while(nums[k]==nums[k+1] && k<nums.Length && k>j)
                    {
                        k--;
                    }
                     while(nums[j]==nums[j-1] && j>i && j<k )
                    {
                        j++;
                    }

                    result.Add(res);
                   

                }
            }
        }
        return result;
    }
}