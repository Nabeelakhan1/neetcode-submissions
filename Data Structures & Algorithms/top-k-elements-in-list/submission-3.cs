public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
       Dictionary<int,int> map=new();
        for(int i=0;i<nums.Length;i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else{
                map.Add(nums[i],1);
                
            }
        }
        int[] result=new int[k];

        //top frequent 
        for(int i=0;i<k;i++)
        {
            int maxFreq=-1;
            int maxNum=0;

            foreach(var pair in map)
            {
                if(pair.Value>maxFreq)
                {
                    maxFreq=pair.Value;
                    maxNum=pair.Key;
                }

            }
            result[i]=maxNum;
            map.Remove(maxNum);
        }
        return result;
    
    }
}
